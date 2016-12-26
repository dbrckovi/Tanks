pdn files can be opened with Paint.Net


HeavyTank.pdn, MediumTank.pdn, LightTank.pdn 
	- general layout for tank types
	- not used by the game directly
	- currently, track locations can be determined using these files

HeavyTracks.png, MediumTracks.png, LightTracks.png
	- All frames animating tracks of a tank type
	- Image is divided vertically by number of frames, and each part is one frame
	- intended to be used by game code

TODO:

 - Extract bodies from HeavyTank.pdn, MediumTank.pdn and LightTank.pdn and save them as png files
 - Extract track locations for all 3 tank types, and put them into code
 - Currently, there is no particular color pattern. Later, each image should contain only 3 colors
	- Gray - base color
	- Black - shadow (dark parts)
	- White - highlight
	
	These colors will be replaced by the game by different colors for each player

 - Turrets should be extracted into separate files