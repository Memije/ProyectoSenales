int microfono = A0;


void setup() {
  // put your setup code here, to run once:
  Serial.begin(2000000);  
}

void loop() {
  // put your main code here, to run repeatedly:
  double res = (double)((((analogRead(microfono) * 5.0f) / 1024.0f)));
  Serial.print(res);
  Serial.print("\n");
  // delay(100);
}
