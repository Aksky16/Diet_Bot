# Diet_Bot
A chatbot which gives you diet plans, calculates BMI and calculates your Ideal Weight.

## Details
- Made using Bot Framework composer.(Download Bot Framework composer [here][1])
- 3 Custom Actions were to calculate BMI and Ideal Weight .(Learn how to create custom actions [here][2])
- Tested in web chat and Bot Framework emulator.(Download Bot Framework emulator [here][3])

## What is BMI?
- Body mass index (BMI) is a value derived from the weight and height of a person. 
- The BMI is defined as the body mass divided by the square of the body height, and is expressed in units of kg/m2, resulting from mass in kilograms and height in metres.
- In this Bot the height is taken in centimetres.
- Major adult BMI classifications are underweight (under 18.5 kg/m2), normal weight (18.5 to 24.9), overweight (25 to 29.9), and obese (30 or more).
- Physical characteristics are not thoroughly taken into account.
- BMI calculations cannot distinguish muscle and fat weight.
- BMI is used differently for children.

## Ideal Weight Calculation
### B. J. Devine Formula (1974)
- Male:	50.0 kg + 2.3 kg per inch over 5 feet
- Female:	45.5 kg + 2.3 kg per inch over 5 feet

[1]:https://github.com/microsoft/BotFramework-Composer/blob/main/README.md
[2]:https://docs.microsoft.com/en-us/composer/how-to-create-custom-actions#:~:text=1%20Open%20the%20bot%20in%20Composer.%20Select%20a,to%20test%20the%20bot%20in%20Web%20Chat.%20
[3]:https://github.com/microsoft/BotFramework-Emulator
