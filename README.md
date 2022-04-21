# restaurant_project_643450063-8

ความเป็นมาของโปรแกรม
เนื่องจากผมต้องการไปกินอาหารที่ร้านผมเลยว่าร้านอาหารสมัยนี้ควรทำงานยังไง ผมจึงคิดการคำนวนการจองในร้านอาหารเพื่อความสะดวกสะบายที่การซื้อขายด้วยความรวดเร็ว และเหตุผลอีกอยากคือการป้องปกจากเชื้อไวรัสโควิด-19อีกด้วย ดังนั้นผมจึงทำโปรแกรมนี้ขึ้นมา ครับ

วัตถุประสงค์ของโปรแกรม
เพื่อการ ระบุยืนยันตัวตนและการคำนวนโดยอัตโนมัติเพื่อรวดเร็วและความสะดวกสบายอีกด้วย

 ClassDiagram
```mermaid-example
 classDiagram
      Animal <|-- Duck
      Animal <|-- Fish
      Animal <|-- Zebra
      Animal : +int age
      Animal : +String gender
      Animal: +isMammal()
      Animal: +mate()
      class Duck{
          +String beakColor
          +swim()
          +quack()
      }
      class Fish{
          -int sizeInFeet
          -canEat()
      }
      class Zebra{
          +bool is_wild
          +run()
      }
```


ชื่อของผู้พัฒนาโปรแกรม
นาย กมล จันบุตรดี 643450063-8
