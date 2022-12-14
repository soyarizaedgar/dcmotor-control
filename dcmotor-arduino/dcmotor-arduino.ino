//Motor 1
int moti1=11;
int motd1=10;

//Motor 1
int moti2=6;
int motd2=5;


//SPEED
const int vel = 255;
const int pinENA = 9;
const int pinENB = 3;

void setup() {
  pinMode(moti1,OUTPUT);
  pinMode(motd1,OUTPUT);
  pinMode(moti2,OUTPUT);
  pinMode(motd2,OUTPUT);
  pinMode(pinENA,OUTPUT);
  pinMode(pinENB,OUTPUT);
  Serial.begin(9600);
}

void loop() {
  char caracter;
    
    if(Serial.available()>0){
      
      caracter = Serial.read();
  
      switch(caracter){
  
        case 'R':
        digitalWrite(moti1,LOW);
        digitalWrite(motd1,HIGH);
        analogWrite(pinENA, vel);
        break;
        
        case 'L':
        digitalWrite(moti1,HIGH);
        digitalWrite(motd1,LOW);
        analogWrite(pinENA, vel);
        break;

        case 'S':
        analogWrite(pinENA, 0);
        analogWrite(pinENB, 0);
        break;

        case 'F':
        digitalWrite(moti2,LOW);
        digitalWrite(motd2,HIGH);
        analogWrite(pinENB, vel);
        break;
        
        case 'B':
        digitalWrite(moti2,HIGH);
        digitalWrite(motd2,LOW);
        analogWrite(pinENB, vel);
        break;


        default:
        
        break;
    }
  }
}
