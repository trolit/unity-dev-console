# Unity Developer Console
 
## Description
<p align="justify">
 First of all, thanks to <a href="https://github.com/joeythelantern" target="_blank">Joey</a> for creating awesome tutorial on making developer console in Unity. I've managed to use it for engineering app purposes which grew pretty much. Without that we would have problems covering all cases (<a href="https://forum.unity.com/threads/is-anyone-using-unit-tests-in-real-projects.650536/">unit tests</a> are not solution in most cases, at least for now). If you are making bigger app/game, developer console is <strong>obligatory</strong> to save functional testing time in both editor mode or release. I made some modifications and wanted to share the results with you. Left on second Joey video tip (as an answer) in the comments but saw many people having problem with making parameters to work, so here is my modified version. That is the main change. Console allows to pass not only command but parameters allowing to create commands like obtain PlayerPrefs key, rewrite held value, load scene by identity from build settings or name. I have left some command examples including <em>help</em> with two states, without paramter which shows list of possible commands and with parameter showing details of specified command. What I also added is extra method <em>ScrollDown()</em> Coroutine which forces the console to scroll down automatically after each command. There is also input field focus after pushing <strong>~</strong> character, so you don't need to use mouse to click on it just after turning console on. I also made some solid output notes which are easy to modify in one place instead of for ex. 20. Predefined some hex colors and they can be used to colorize syntax, warnings etc like in that example. I did not feed console with Debug messages but you can easily do it by yourself following Joey's second part of the tutorial <a href="https://youtu.be/isURlDFyxe0?list=PLdSnLYEzOTtrlPwmaYkkPmRYMrVRDVeTI" target="_blank">over here</a> and adjusting code. Enjoy!
</p>

## Repository info
<p align="justify">
Repository consists of Unity project with one template scene allowing to test console and scripts directory. I left some example commands which I found very useful in my team project for engineering thesis so take a look at them! 
</p>

## How passing parameters work?

<p align="center">
<img src="https://github.com/trolit/unity-dev-console/blob/master/images/codeFrag.PNG" alt="Code fragment" width="780px"></img>
</p>

<p align="justify">
Take a look at code fragment above. The possibility to pass parameters is due to adding parameter to procedure RunCommand, string[] data (see line 26). How to process passed data? Well, before that, keep strongly in mind that resolving parameters passing that way requires you to be careful on index reference and popular "out of range" problem. On each index you will find whole command cut into pieces. Check following image. 
</p>

<p align="center">
<img src="https://github.com/trolit/unity-dev-console/blob/master/images/examples.PNG" alt="Examples" width="780px"></img>
</p>

<p align="justify">
Imagine that you want to get the value of the PlayerPrefs key (first example). To do this you need from user to specify first in which type that key is saved. After you get this, you can extract that information and make proper conditionals like in first image. Remember that if you work on array you have fixed length. It is worth to feed all cases that can happen to prevent critical errors. With getting key value you can cover string, float, int and situation in which your data consists of more than 3 elements (command, type, key). If you want to change scene (second example) you need to be aware that before you use LoadSceneAsync(int sceneBuildIndex), you have to extract text under data[1], which stands for identity, then convert it into expected type (using for example <em>Convert.ToInt32(param)</em>). Instead of making two scripts: <em>loadById</em> and <em>loadByName</em> in repository you will find one - <strong>CommandLoadScene</strong> that cover both situations where first check handles whether user passed Id or scene name.   
</p>

## Presentation
<p align="center">
<img src="https://github.com/trolit/unity-dev-console/blob/master/images/ezgif.gif" alt="Gif generated from https://ezgif.com" width="780px"></img>
</p>

## Authors
- Joey The Lantern, <a href="https://github.com/joeythelantern" target="_blank">github</a>, <a href="https://www.youtube.com/channel/UCmG1UbEI0iFE1tAw2SyvvXg" target="_blank">youtube channel</a>
- trolit, <a href="https://trolit.github.io/">github</a>

Joey's Unity Developer Console series <a href="https://www.youtube.com/watch?v=ztG10Z00HKM&list=PLdSnLYEzOTtrlPwmaYkkPmRYMrVRDVeTI&index=1" target="_blank">is available here</a>
