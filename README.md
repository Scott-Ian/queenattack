# Queen Assault

#### Can the Queen attack? 07/13/2020

#### By Ian Scott, Tristan Emmerson, Cody Fritz

## Description
A simple application that allows you to enter chess coordinates of a queen and another unit and determine if the Queen can attack that unit, or not.

## Setup/Installation Requirements

1. From [github]( https://github.com/tmemmerson/queenattack.git ) navigate to "Repositories"
2. Select project from list
3. Click "Clone or download v" Download Zip
4. Open .zip with program of choice (Winrar/7zip confirmed working)
5. Extract folder to location of choice(such as desktop)
6. 

## Known Bugs

No known bugs!

## Support and contact details

For support please contact [Tristan Emmerson](tristan@stickerslug.com)

## Technologies Used

VSC / C#, dotnet, netcoreapp, Microsoft.NET.SDK

### License

MIT

Copyright (c) 2020 **Cody Fritz, Tristan Emmerson, Ian Scott**

### Specs
| Spec 	| Input 	| Output 	|
|-	|-	|-	|
| Receive X and Y coordinates for a "Queen" 	| 4,4 	| Queen Position: (4,4) 	|
| Receive X and Y coordinates for another chess piece 	| 8,2 	| Opponent Position (8,2) 	|
| If Queen can attack opponent, return true, else false<br>   if queen.x = opponent.x = true<br>   if queen.y = opponent.y = true<br>   if queen.x-opponent.x == queen.y-opponent.y = true 	| <br>n/a 	| true/false 	|

