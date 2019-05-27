#include <TimerOne.h>



#include <Stepper.h>

#include <Ethernet.h> //Load Ethernet Library
#include <EthernetUdp.h> //Load UDP Library
#include <SPI.h> //Load the SPI Library

//////configuracion de ethernet
byte mac[] = { 0xDE, 0xA8, 0xBA, 0xEF, 0xFE, 0xEE}; //Assign a mac address
IPAddress ip(192, 168, 1, 177); //Assign my IP adress
unsigned int localPort = 8888; //Assign a Port to talk over
char packetBuffer[UDP_TX_PACKET_MAX_SIZE];
String datReq; //String for our data
int packetSize; //Size of Packet
EthernetUDP Udp; //Define UDP Object

////// configuracion de stepper
const int stepsPerRevolution = 2048;  // change this to fit the number of steps per revolution
// for your motor
// initialize the stepper library on pins 8 through 11:
const int out1 =  8;
const int out2 =  9;
const int out3 =  3;
const int out4 =  4;
Stepper myStepper(stepsPerRevolution, 23, 27, 25, 29);

int stepCount = 0;         // number of steps the motor has taken

String CMD="";
long DATA=0;

///banderas de position y timer
int banderaPosition=0;
int banderaTimer=0;
int cuentalimite=0;
bool stopped=true;
bool started=false;
bool paused=false;
bool resumed=false;
void setup() {
  myStepper.setSpeed(20);

  
  // put your setup code here, to run once:
           // initialize timer1, and set a 1/2 second period
  Timer1.initialize(1757812);
  Timer1.attachInterrupt(callback);  // attaches callback() as a timer overflow interru
  Timer1.stop();
  
  ////ethernet
  Serial.begin(9600);
  Ethernet.begin(mac, ip); //Initialize Ethernet
  Udp.begin(localPort); //Initialize Udp
  IPAddress remoteip(192,168,1,102);
  IPAddress remoteport(10000);
  delay(500); //delay
  myStepper.setSpeed(10);
 
}

void loop() {
  // put your main code here, to run repeatedly:
 
  /////poleo
   packetSize = Udp.parsePacket(); //Read theh packetSize

    if(packetSize>0){
      
      String data= Read();
      DATA=0;
      for (int i = 0; i < data.length(); i++) {
        if (data.substring(i, i+1) == "|") {
            CMD = data.substring(0, i);
            DATA = data.substring(i+1).toInt();
              break;
            }
          }

          
          if(CMD=="S"){
              Start();
               Send("Start OK",1);
               Serial.println("Start ok");
            }

          if(CMD=="ST"){
              Stop();
              Send("Stop OK",1);
              Serial.println("Stop ok");
            }

          if(CMD=="PS"){
              Pause();
              Send("Pause OK",1);
              
            }

          if(CMD=="RS"){
              Resume();
              Send("Resume OK",1);
            }

          if(CMD=="VY"){
              SetSpeed(DATA);
            }

          if(CMD=="T"){
              setTime(DATA);
              Send("Time OK",1);
              Serial.println("set time ok");
            }

          if(CMD=="H"){
            Send("Home OK",1);
             Home();
             Serial.println("home ok");
            }

          if(CMD=="SP"){
            Serial.print("cuentas =");                   
            SetPosition(DATA);            
            Send("SetPosition OK",1);
            }

          if(CMD=="Left"){
              Left(DATA);
            }

          if(CMD=="Right"){
             Right(DATA);
            }
            
          if(CMD=="StopEn"){
            Serial.println("motor stopped");
            }
    }
    memset(packetBuffer, 0, UDP_TX_PACKET_MAX_SIZE);

    if(stepCount>=cuentalimite && stopped==false){
      Stop();     
      }
    
}

void callback(){

    if(stepCount<cuentalimite && stepCount!=cuentalimite){
        myStepper.step(-1);        
        stepCount=stepCount+1;
        //Send("COUNTING",stepCount); 
        Serial.print("counting ");
        Serial.println(stepCount);
      }
   
  }

void SetSpeed(long period){
     Timer1.stop();
     Timer1.setPeriod(period);
     Serial.println(period);
  }

void setTime(int tiempo){
  
    Timer1.stop();
    delay(200);
    Timer1.setPeriod(1757812);
    Timer1.stop();
    banderaTimer=1;
    banderaPosition=0;
    
    if(banderaTimer==1){
        cuentalimite=tiempo;
        }
  
    if(banderaPosition==1){
        cuentalimite=0;
        }
  
  }

void Start(){
  //TurnOn();
  if(banderaTimer==1){
        cuentalimite=cuentalimite;
     }

  if(banderaPosition==1){
        cuentalimite=0;
        }
  Timer1.setPeriod(1757812);
  //Timer1.resume();
   stopped=false;
   started=true;
   
  }

void Resume(){
   Timer1.resume();
   resumed=true;
   paused=false;
  }

void Stop(){
  //TurnOff();
  Send("Stopped",1);
  Timer1.stop();
   stopped=true;
   started=false;
  }

void Alert(){
  }

void Pause(){
  Timer1.stop();
  resumed=false;
  paused=true;
  }

void Send(String estatus,int cuenta){
  /////cmd
    char cstr[16];
    itoa(cuenta, cstr, 10);
    Udp.beginPacket(Udp.remoteIP(), Udp.remotePort());  //Initialize Packet send 
    Udp.print(estatus); //Send string back to client 
    Udp.print("|");
    Udp.print(cuenta);
    Udp.endPacket(); //Packet has been sent
  }

String Read(){
    Udp.read(packetBuffer, UDP_TX_PACKET_MAX_SIZE); //Reading the data request on the Udp
    String datReq(packetBuffer);
    return datReq;
  }


void Right(int cuenta){
    Timer1.stop();
    Serial.println("motor hacia adelante"); 
    myStepper.step(5);
  }


void Left(int cuenta2){
    Timer1.stop();
    Serial.println("motor hacia atras");
    cuenta2=cuenta2 - 2*cuenta2;
    myStepper.step(-5);
  }

void StopEngine(){
   Serial.println("Engine Stopped");
  }
  
void TurnOff(){
  digitalWrite(out1, LOW);
  digitalWrite(out2, LOW);
  digitalWrite(out3, LOW);
  digitalWrite(out4, LOW);
  }


void TurnOn(){
  digitalWrite(out1, HIGH);
  digitalWrite(out2, HIGH);
  digitalWrite(out3, HIGH);
  digitalWrite(out4, HIGH);
  }


void Home(){
    Timer1.stop();
    delay(200);
    /*
    if(stepCount>0){
         myStepper.step(stepCount);
         stepCount=0;
      }
     else if(stepCount<0)
     {
        myStepper.step(stepCount);
        stepCount=0;
      
     }
     else if(stepCount==0){
       Serial.println("");
      }
     */
    if(stepCount>0){
      myStepper.step(stepCount);
         stepCount=0;
      }

    if(stepCount<0){
      myStepper.step(stepCount);
         stepCount=0;
      }       
    stepCount=0;
    cuentalimite=0;
  }


void SetPosition(int cuenta3){

    Home();
    delay(100);
    
  
    myStepper.step(cuenta3);
    stepCount=-cuenta3;
    Serial.println(stepCount);
    Timer1.setPeriod(1757812);
    Timer1.stop();

     banderaTimer=0;
    banderaPosition=1;
    
    if(banderaTimer==1){
      cuentalimite=cuenta3;
      }

    if(banderaPosition==1){
      cuentalimite=0;
      }
  }
