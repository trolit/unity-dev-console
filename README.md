# Unity Developer Console
 
## Description
<p align="justify">
 First of all, thanks to <a href="https://github.com/joeythelantern" target="_blank">Joey</a> for creating awesome tutorial on making developer console in Unity. I've managed to use it for my engineering app purposes. If you are making bigger app/game, developer console is <strong>obligatory</strong> to save testing time in both editor mode or release. I made some modifications and wanted to share the results with you. Left on first Joey video tip in comments but saw many people having problem with making parameters to work so here is my modified version. That is the main change. Console allows to pass not only command but parameters allowing to create commands like obtain PlayerPrefs key, rewrite held value, load scene by identity from build settings or name. I have left some command examples including help with two states, without paramter which shows list of possible commands and with parameter showing details of specified command. What I also added is extra method <em>ScrollDown()</em> Coroutine which forces the console to scroll down automatically after each command. There is also input field focus after pushing ~ character so you don't need to use mouse to click on it just after turning console on. I also made some solid output notes which are easy to modify in one place instead of for ex. 20. Predefined some hex colors so they can be used to colorize syntax, warnings etc like in that example. I did not feed console with Debug messages but you can easily do it by yourself following Joey's second part of the tutorial <a href="https://youtu.be/isURlDFyxe0?list=PLdSnLYEzOTtrlPwmaYkkPmRYMrVRDVeTI" target="_blank">over here</a> and adjusting code.
</p>

## Repository info
<p align="justify">
Repository consists of Unity project with one template scene allowing to test console and scripts directory. I left some example commands which I found very useful in team project so take a look at them! 
</p>

## How passing parameters work?

<p align="center">
<img src="https://github.com/trolit/unity-dev-console/blob/master/images/codeFrag.PNG" alt="Code fragment" width="780px"></img>
</p>

<p align="justify">
Take a look at code fragment above. The possibility to pass parameters is due to adding parameter to procedure RunCommand, string[] data (see line 26). How to process passed data? Well, before that keep strongly in mind that resolving it that way requires you to be careful on index reference and popular "out of range" problem. On each index you will find whole command cut into pieces. Check following image. 
</p>

<p align="center">
<img src="https://github.com/trolit/unity-dev-console/blob/master/images/examples.PNG" alt="Examples" width="780px"></img>
</p>

<p align="justify">
Imagine that you want to get the value of the PlayerPrefs key. To do this you need from user to specify first in which type that key is saved. After you get this, you can extract that information and make proper conditionals like in first image. Remember that if you work on array you have fixed length. It is worth to feed all cases that can happen. With getting key value you can cover string, float, int and situation in which your data consists of more than 3 elements: command, type, key. If you want to change scene you need to be aware that before you use LoadSceneAsync(int sceneBuildIndex) you have to extract text under data[1] which stands for identity and convert it into expected type. Instead of making two scripts: <em>loadById</em> and <em>loadByName</em> in repository you will find one that cover both situations but first checks whether user passed Id or scene name.   
</p>



## Authors
- Joey The Lantern, <a href="https://github.com/joeythelantern">homepage</a>
- trolit, <a href="https://trolit.github.io/">homepage</a>


Follow Joe The Lantern tutorial over here:
https://www.youtube.com/watch?v=ztG10Z00HKM&t=1328s


Then...
