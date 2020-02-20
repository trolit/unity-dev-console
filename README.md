# Unity Developer Console
 
## Description
<p align="justify">
First of all, thanks to Joey for creating awesome tutorial on creating developer console. I've managed to use it for my engineering app purposes. If you are making bigger app/game, developer console is obligatory to save testing time either in editor mode or release. I made some modifications and wanted to share the results with you. Left on first Joey video tip but saw many people having problem with making parameters to work so here is my modified version. Main change is that console allows to pass not only command but parameters allowing to create commands like obtain PlayerPrefs key, rewrite it, load scene by identity from build settings or name. I have left some command examples including help with two states, without paramter it shows list of possible commands, with parameter shows details of typed command. What I also added is extra method ScrollDown which forces the console to scroll down automatically after each command. There is also input field focus after pushing ~ character so you don't need to use mouse to reach input. I also made some solid output notes which let easily modify them only in one place instead of for ex. 20. Predefined also some hex colors so they can be used to colorize syntax, warnings etc. I did not feed console with Debug messages but you can easily do it by yourself following Joey's second part of the tutorial <a href="https://youtu.be/isURlDFyxe0?list=PLdSnLYEzOTtrlPwmaYkkPmRYMrVRDVeTI" target="_blank">over here</a>.
</p>

## Repository info
<p align="justify">
Repository consists of Unity project with one template scene allowing to test console and scripts directory. I left some example commands which I found very useful in team project so take a look at them! 
</p>

## Authors
- Joey The Lantern, <a href="https://github.com/joeythelantern">homepage</a>
- trolit, <a href="https://trolit.github.io/">homepage</a>


Follow Joe The Lantern tutorial over here:
https://www.youtube.com/watch?v=ztG10Z00HKM&t=1328s


Then...
