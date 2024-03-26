# Installation
1. Download the latest release.
2. Extract the "Typing Emulator" folder wherever you want.
3. Run the .exe file and close it again.
4. Now can put your .txt file, inside the "data" folder and don't forget to change the filename, to "content.txt".

# Changing Settings
1. Go inside the "data" folder and open settings.json, with your preferred editor (recommended: VSCode or Notepad++).
2. Explaining of the Variables:
   ### general
   - ***Filename***, requires a string that represents a file and its extension.
     The variable is used to recognise, what the file is named, that it gets the content to type from.
   ### emulator
   - ***TypingSpeedFalloffChance***, requires a double/integer and represents a percentage chance.
     The variable is used to give a chance to type slower than usual.
   - ***LowestTypeFalloffMS***, requires an integer, it represents the fastest typing speed possible and is in miliseconds.
     The variable is used, to determine the actual typing speed.
   - ***HighestTypeFalloffMS***, requires an integer, it represents the slowest typing speed possible and is in miliseconds.
     The variable is used, to determine the actual typing speed.
   - ***FalloffMultiplier***, requires an integer, that represents a multiplier, that multiplies the falloff, of the current typing speed.
     The variable is used, to slow down the typing speed, and can get slower than the max value of ***HighestTypeFalloffMS***.
   - ***AllowWhitespaceFalloff***, requires a boolean and is used, to check if whitespaces, will get delayed or get typed instantly.
   - ***TypoChance***, requires a double/integer and represents a percentage chance.
     The variable is used to give a chance to make a typo (typing error), that needs to be corrected.
   - ***ThinkingFalloffChance***, requires a double/integer and represents a percentage chance.
     The variable is used to give a chance to pause the typing, to emulate a quick pause for thinking.
   - ***LowestThinkingFalloffMS***, requires an integer, it represents the shortest thinking time possible and is in miliseconds.
     The variable is used, to determine the actual thinking time.
   - ***HighestThinkingFalloffMS***, requires an integer, it represents the longest thinking time possible and is in miliseconds.
     The variable is used, to determine the actual thinking time.
# How to use TypingEmulator
1. Put your .txt file, inside the "data" folder and name your file, as the variable ***Filename***, in the settings.json (Default: content.txt).
2. Run the .exe file.
# Problem solving
### The .exe file does not start or shows an error message, similar to "Download .Net 8.0 to run the application".
1. Go inside the "redist" folder, run the .exe file named "Placeholder" and go through the proceedure.
- If it still doesn't work, restart your PC and try to run it again.
- If it still doesn't work, you can contact me for help.
