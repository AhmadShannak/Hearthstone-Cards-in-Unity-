# Hearthstone Cards in Unity

## Preview
This section provide an overview of this project.

## Tutorial
For those who are interested in making this from zero and how i did it ,this section is for you.
  #### Prerequisite
  1- You need to create a new game in unity ,and set it to 2D .
  
  2- Copy and paste the Sprites folder (if you dont have a design for your cards , and images ).
  
  ### Steps 
  1- After you create a game project in unity , select your **Main Camera** and change it's **Projection** to **Perspective** ; as this will help alot when using UI elements.
  
  2- Create a **Canvas** to hold our cards in it ,and rename it to **Main Canvas**.
  
  3- Create another **Canvas** inside of the **Main Canvas** ,and name it **Card**.
  
  4- Now lets play around with our **Card** (Card Canvas).
  
  - Start By deleting every component on the **Card** leaving only the **Rect Transform** component.
  
  - Add a **Canvas Renderer** from the **Add Component**.
   
  - Now create an **Image** inside of the **Card** , Name it **Card Template**.
   
  - From the **Image (Script)** Press **Source Image** and link it to the **Card** sprite that exist in the sprites folder(in case you want to use the same card image that i used).
  
  - Change the **Scale** of the image to fit the size you are looking for (in my case 2 from the X-Axis and 3 from the Y-Axis).
  
  5- Right click on the **Card** and add a **Text** from the **UI** tab then name it **HP**.
  
  6- Change it's text to 10 and align to be on the top of the red part of the **Card** , and choose the font you want (in my case i used the font from the **Font** folder above ) ,also change the color to white , and add an **Outline (Script)** from the **Add Component** then set the **Effect Distance** to what you want ( in my case X = 1.35 , Y = -2).
  
  7- Repeat **Step 6** for the name , attack points (Yellow part of the card) ,description , and mana (Blue part of the card) .
  - On finishing **Step 7** you are supposed to end up with something like this:
  ![ScreenShot]()
  
  
  
