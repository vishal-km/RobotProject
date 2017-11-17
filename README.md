
C# Console Application - Simple Robot Program

The application is a simulation of a toy robot moving on a square tabletop, of dimensions 5 units x 5 units.
There are no other obstructions on the table surface.
The robot is free to roam around the surface of the table, and is prevented from falling to destruction. Any movement that would result in the robot falling from the table is prevented, however further valid movement commands must still be
allowed.

**Features**
* Easy and user friendly positioning
* Easily Maneuverable using arrow keys
* Edge detection and warning intelligence using color change
* Position and direction reporting **


Allowed Commands :

* PLACE X,Y,F - P command
* MOVE - Up arrow
* LEFT -  Left Arrow
* RIGHT -  Right Arrow
* REPORT - R Command


PLACE will put the toy robot on the table in position X,Y and facing NORTH, SOUTH, EAST or WEST.
The origin (0,0) is considered to be the SOUTH WEST most corner.
The first valid command to the robot is a PLACE command, after that, any sequence of commands may be issued, in any order, including another PLACE command.
The application should discard all commands in the sequence until a valid PLACE command has been executed.

MOVE will move the toy robot one unit forward in the direction it is currently facing.

LEFT and RIGHT will rotate the robot 90 degrees in the specified direction without changing the position of the robot.

REPORT will announce the X,Y and F of the robot. For User experiance, a matrix representation of the position is also provided.

A robot that is not on the table will ignore the MOVE, LEFT, RIGHT and REPORT commands.

User can enter the input commands directly to the console application


