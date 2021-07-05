#define inbits 14         // число значений в массиве, который хотим получить
#define b 50 //задержка в передаче между каналами microseconds 50
#define c 50 //задержка после передачи в мс

//byte receivenew;
byte indexsend;
bool recievedflag;
bool sendingflag;
bool startflag;
bool stopflag;
bool pwmflag;

bool flagone;
bool flagtwo;

byte indata[inbits]; // входящие данные
byte pressures[16]; // массив давлений на отправку
byte currents[16];  // массив токов на отправку
byte pwms [8];
//byte timer [3];
unsigned long totaltime;


 unsigned long previousstarttimer=0;

unsigned long sendtimer = 0;
const long sendinterval = 2000;

unsigned long previousMillis = 0;      
const long interval = 1000;
//sizeof(incomingByte)

void sendingpress() { //отправка давлений


Serial.write(pressures[0]); Serial.write(pressures[1]);
delayMicroseconds(b);
Serial.write(pressures[2]); Serial.write(pressures[3]);
delayMicroseconds(b);
Serial.write(pressures[4]); Serial.write(pressures[5]);
delayMicroseconds(b);
Serial.write(pressures[6]); Serial.write(pressures[7]);
delayMicroseconds(b);
Serial.write(pressures[8]); Serial.write(pressures[9]);
delayMicroseconds(b);
Serial.write(pressures[10]); Serial.write(pressures[11]);
delayMicroseconds(b);
Serial.write(pressures[12]); Serial.write(pressures[13]);
delayMicroseconds(b);
Serial.write(pressures[14]); Serial.write(pressures[15]);

delay(c);
  
}

void sendingcurr(){  //отправка токов отправляется после 4х отправок давлений
  Serial.write(252);
  delayMicroseconds(b);
 Serial.write(currents[0]); Serial.write(currents[1]);
delayMicroseconds(b);
Serial.write(currents[2]); Serial.write(currents[3]);
delayMicroseconds(b);
Serial.write(currents[4]); Serial.write(currents[5]);
delayMicroseconds(b);
Serial.write(currents[6]); Serial.write(currents[7]);
delayMicroseconds(b);
Serial.write(currents[8]); Serial.write(currents[9]);
delayMicroseconds(b);
Serial.write(currents[10]); Serial.write(currents[11]);
delayMicroseconds(b);
Serial.write(currents[12]); Serial.write(currents[13]);
delayMicroseconds(b);
Serial.write(currents[14]); Serial.write(currents[15]); 
Serial.write(252);
delay(c);
}

void pressuretransform(byte index, unsigned int val){ // преобразование давлений для отправки
 byte ext;
 byte a;
 index=index << 1;
 constrain(index, 0, 15);
 val=map(val,0,1023,0,4095);
 constrain(val, 0, 4095);
 a = val >> 8;
  if(val<=255){
    ext=val; 
  }else if (val>255 && val<=511){
    ext=val-256;
  }else if (val>511 && val<=767){
    ext=val-512;
  }else if (val>767 && val<=1023){
    ext=val-768;
  }else if (val>1023 && val<=1279){
    ext=val-1024;
  }else if (val>1279 && val<=1535){
    ext=val-1280;
  }else if (val>1535 && val<=1791){
    ext=val-1536;
  }else if (val>1791 && val<=2047){
    ext=val-1792;
  }else if (val>2047 && val<=2303){
    ext=val-2048;
  }else if (val>2303 && val<=2559){
    ext=val-2304;
  }else if (val>2559 && val<=2815){
    ext=val-2560;
  }else if (val>2815 && val<=3071){
    ext=val-2816;
  }else if (val>3071 && val<=3327){
    ext=val-3072;
  }else if (val>3327 && val<=3583){
    ext=val-3328;
  }else if (val>3583 && val<=3839){
    ext=val-3584;
  }else if (val>3839 && val<=4095){
    ext=val-3840; 
  }
pressures[index]= ext;
index++;
pressures[index]= a;
}

void sensread(){ //чтение аналоговых входов и отправка данных
 pressuretransform(0,analogRead (A0));
 pressuretransform(1,analogRead (A1));
 pressuretransform(2,analogRead (A2));
 pressuretransform(3,analogRead (A3));
 pressuretransform(4,analogRead (A4));
 pressuretransform(5,analogRead (A5));
 pressuretransform(6,analogRead (A6));
 pressuretransform(7,analogRead (A7));
 
 
 if (micros() - sendtimer >= sendinterval) {
    sendtimer+=sendinterval; 
  indexsend++;
 if (indexsend==4){
  indexsend=0;
  sendingcurr();
 }else{
  
  sendingpress();
 }
 }  

}


void parsing() {//парсинг входящих данных
  //Serial.print(Serial.available());
  if (Serial.available() > 0) {//слушаем ком порт
    
    Serial.readBytes(indata, inbits);
     recievedflag=1;
    Serial.print("have 1 step");
    Serial.print(inbits);
    
    
  }

  if (recievedflag==1&&indata[0]==116){//старт данных
   sendingflag=1;
   recievedflag=0;
   
   flagone = 1;
  }
  
  if(flagone == 1){
    Serial.print("already have two");
    Serial.print("have 2 step###############");
   }


if (recievedflag==1   &&   indata[0]==120 && indata[1]==0 &&   indata[2]==0){
  Serial.print("have 3 step##############");
startflag=1;
previousstarttimer = millis();
sendtimer= micros();

Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
delayMicroseconds(b);
Serial.write(254); Serial.write(255);
  recievedflag=0;
  flagtwo = 1;
}

if (flagtwo == 1){
  Serial.print(" we have 2 flag already! ");
}
if (recievedflag==1&&indata[0]==120&&indata[1]==138&&indata[2]==2||stopflag==1&&startflag==0){
  //sendingflag=0;
  stopflag=0;
  Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
delayMicroseconds(b);
Serial.write(255); Serial.write(255);
  recievedflag=0;
}
if (recievedflag==1&&indata[0]==84){//стоп данных, обнуление времени
  sendingflag=0;
  totaltime = 0;
  recievedflag=0;
}
if (recievedflag==1&&indata[0]==113){
pwms[0]=indata[1];
pwms[1]=indata[3];
pwms[2]=indata[5];
pwms[3]=indata[7];  
  pwmflag=1;
  recievedflag=0;
}
if (recievedflag==1&&indata[0]==81){
pwms[4]=indata[1];
pwms[5]=indata[3];
pwms[6]=indata[5];
pwms[7]=indata[7]; 
  pwmflag=1; 
  recievedflag=0;
}
if (recievedflag==1&&indata[0]==115&&indata[2]==0){
//timer[0]=indata[11];
//timer[1]=indata[12];
  unsigned int intime;
  recievedflag=0;
intime = indata[12] << 8;
intime = intime+indata[11]; 
 totaltime = totaltime+intime;
}
   
}

void pwmsend() {
if (pwms[0]>0||pwms[1]>0||pwms[2]>0||pwms[3]>0||pwms[4]>0||pwms[5]>0||pwms[6]>0||pwms[7]>0){
 PORTB=B00100000;
}else {PORTB=B00000000;
}


  
}

void setup() {
  //Serial.begin(9600);
  Serial.begin(115200);
  Serial.print("Setup!!");
  flagone = 0;
  flagtwo = 0;
  pinMode(13,OUTPUT);
pinMode(3,OUTPUT);
pinMode(5,OUTPUT);
pinMode(6,OUTPUT);
pinMode(9,OUTPUT);
pinMode(10,OUTPUT);
pinMode(11,OUTPUT);
  
  pinMode (A0, INPUT);
  pinMode (A1, INPUT);
  pinMode (A2, INPUT);
  pinMode (A3, INPUT);
  pinMode (A4, INPUT);
  pinMode (A5, INPUT);
  pinMode (A6, INPUT);
  pinMode (A7, INPUT);


for (byte i = 1; i < 16; i=i+2) {
  currents[i]=16;
}

 //currents[0]=255;
}








void loop() {
  //Serial.print("looper");
  //Serial.write(254);
  //delayMicroseconds(b);
  //Serial.write(255);
  //delay(200);

//if (startflag==1){
//if (millis() - previousstarttimer >= totaltime) { 
//    startflag=0;
//    stopflag=1;}}
// 
// parsing();
//
// if (sendingflag==1){
// sensread();
// }
// 
//if (pwmflag==1){
// pwmsend();
// pwmflag=0;  
//}

 sensread();

  
/*   unsigned long currentMillis = millis();
if (currentMillis - previousMillis >= interval) {
    previousMillis = currentMillis; 
  Serial.print("time=");
  Serial.println(totaltime);
//analogWrite(3,arr1[1]);
   /* for (byte i = 0; i < inbits; i++) { // выводим элементы массива
      Serial.print(indata[i]); Serial.print(" ");
    } Serial.println();
 for (byte i = 0; i < 8; i++) { // выводим элементы массива
      Serial.print(pwms[i]); Serial.print(" ");
    }Serial.println();
    }*/
}
