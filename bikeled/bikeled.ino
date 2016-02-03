/*
  BikeLED
  controls bikeLED array for turn/brake signals
 */
// map pins to LED diagram i made
// there's probably a better way todo this
int one = 13;
int two = 12;
int three = 11;
int four = 10;
int five = 9;
int six = 8;
int seven = 7;
int twelve = 6;

// the setup function runs once when you press reset or power the board
void setup() { 
  pinMode(one, OUTPUT);
  pinMode(two, OUTPUT);
  pinMode(three, OUTPUT);
  pinMode(four, OUTPUT);
  pinMode(five, OUTPUT);
  pinMode(six, OUTPUT);
  pinMode(seven, OUTPUT);
  pinMode(twelve, OUTPUT);
}

void left() {
  digitalWrite(one, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(two, LOW);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, LOW);
  digitalWrite(seven, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(twelve, LOW);
  delay(100);
  digitalWrite(one, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(two, LOW);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);
  digitalWrite(seven, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(twelve, LOW);
  delay(100);    
  digitalWrite(one, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(two, LOW);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);
  digitalWrite(seven, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(twelve, LOW);
  delay(100);    
  digitalWrite(one, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(two, LOW);
  digitalWrite(three, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);
  digitalWrite(seven, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(twelve, LOW);
  delay(100);
  digitalWrite(one, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(two, LOW);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);
  digitalWrite(seven, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(twelve, LOW);
  delay(500);
  wipe();  
 }

void right() {
  digitalWrite(one, LOW);
  digitalWrite(two, HIGH);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(seven, LOW);
  digitalWrite(twelve, HIGH);
  delay(1000);
  wipe();
}

void brake(){
  digitalWrite(one, HIGH);
  digitalWrite(two, HIGH);
  digitalWrite(three, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, HIGH);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(seven, LOW);
  digitalWrite(twelve, LOW);
  delay(1000);
  wipe();
  
}
void wipe(){
  digitalWrite(one, LOW);
  digitalWrite(two, LOW);
  digitalWrite(three, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(four, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(five, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(six, LOW);   // turn the LED on (HIGH is the voltage level)
  digitalWrite(seven, LOW);
  digitalWrite(twelve, LOW);
}
// the loop function runs over and over again forever
void loop() {
  left();

 // brake();

  //right();

  //brake();
 
}
