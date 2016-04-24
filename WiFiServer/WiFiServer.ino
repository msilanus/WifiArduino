/*
 Serveur Web WiFi basé sur l'exemple SimpleWebServerWifi

 created 25 Nov 2012
 by Tom Igoe
 
 Modifié le 24 Avril 2016
 par Marc Silanus
 
 Allume ou Eteint la led sur la pin 9
 Commandes reçu par socket port 5500
 
 - H : allume la led
 - L : éteint la led
 - M : renvoi sur socket une chaine alphanumérique
 
 Fonctionne avec le programme Visual studio C#
 "WifiArduinoLed"
 
 Modifier "ssid" avec le nom de votre réseau
 Modifier "pass" avec le mot de passe du réseau
 
 Si pas de sécurité modifier :
 WiFi.begin(ssid, pass); => WiFi.begin(ssid);
 
 
 */
#include <SPI.h>
#include <WiFi.h>

char ssid[] = "ssid";      //  your network SSID (name)
char pass[] = "pass";   // your network password
int keyIndex = 0;                 // your network key Index number (needed only for WEP)

int pin = 9;

int status = WL_IDLE_STATUS;
WiFiServer server(5500);

void setup() {
  Serial.begin(9600);      // initialize serial communication
  pinMode(pin, OUTPUT);      // set the LED pin mode

  // check for the presence of the shield:
  if (WiFi.status() == WL_NO_SHIELD) {
    Serial.println("WiFi shield not present");
    while (true);       // don't continue
  }

  String fv = WiFi.firmwareVersion();
  if ( fv != "1.1.0" )
    Serial.println("Please upgrade the firmware");

  // attempt to connect to Wifi network:
  while ( status != WL_CONNECTED) {
    Serial.println("*** Serveur Web WiFi ***");
    Serial.print("En attente de connexion au reseau : ");
    Serial.println(ssid);                   // print the network name (SSID);

    // Connect to WPA/WPA2 network. Change this line if using open or WEP network:
    status = WiFi.begin(ssid, pass);
    // wait 10 seconds for connection:
    delay(10000);
  }
  server.begin();                           // start the web server on port 80
  printWifiStatus();                        // you're connected now, so print out the status
}


void loop() {
  WiFiClient client = server.available();   // listen for incoming clients

  if (client) {                             // if you get a client,
    Serial.println("new client");           // print a message out the serial port
    String currentLine = "";                // make a String to hold incoming data from the client
    while (client.connected()) {            // loop while the client's connected
      if (client.available()) {             // if there's bytes to read from the client,
        char c = client.read();             // read a byte, then
        Serial.write(c);                    // print it out the serial monitor
        if (c == '\n')
        { // if the byte is a newline character

          if (currentLine.length() == 0) break;
          else
          { // if you got a newline, then clear currentLine:
            // Check if the request is "H" or "L".
            if (currentLine == "H")
            {
              // H turns the LED on.
              digitalWrite(pin, HIGH);
              Serial.println("Recu : H");
              client.print("H");
            }
            if (currentLine == "L")
            {
              // L turns the LED off.
              digitalWrite(pin, LOW);
              Serial.println("Recu : L");
              client.print("L");
            }
            if (currentLine == "M")
            {
              // Mesures .
              Serial.println("Recu : M");
              client.print("M243453");
            }
            currentLine = "";
          }
        }
        else currentLine += c;      // add it to the end of the currentLine
      }
    }
    // close the connection:
    client.stop();
    Serial.println("client disonnected");
  }
}
void printWifiStatus() {
  // print the SSID of the network you're attached to:
  Serial.print("SSID : ");
  Serial.println(WiFi.SSID());

  // print your WiFi shield's IP address:
  IPAddress ip = WiFi.localIP();
  Serial.print("Adresse IP : ");
  Serial.println(ip);

  // print the received signal strength:
  long rssi = WiFi.RSSI();
  Serial.print("Force du signal (RSSI):");
  Serial.print(rssi);
  Serial.println(" dBm");
  Serial.print("En attente de commandes...");
  Serial.println();
}
