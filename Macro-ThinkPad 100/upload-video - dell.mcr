LABEL : Start
COMMENT : Go to increase tab
Mouse : 267 : 16 : Click : 0 : 0 : 0
DELAY : 30
COMMENT : Click copy target channel
Mouse : 132 : 310 : Click : 0 : 0 : 0
DELAY : 30
COMMENT : Go to back YT tab
Mouse : 30 : 16 : Click : 0 : 0 : 0
DELAY : 30
COMMENT : ExecuteRandomFile-the first
PLAY MACRO : function\ExecuterandomFile.mcr
COMMENT : Go YouTube.com
COMMENT : Open folder bookmark
Mouse : 127 : 84 : Click : 0 : 0 : 0
DELAY : 30
COMMENT : Select Youtube.com- ve trang chu
Mouse : 127 : 253 : Click : 0 : 0 : 0
DELAY : 5500
COMMENT : Change to target channel
PLAY MACRO : function\ChangeToTargetChannel.mcr
LABEL : Out of determine channel
COMMENT : Go to youTubeStudio
PLAY MACRO : function\GotoChangeInBookmark.mcr
COMMENT : Click Trang tong quan
Mouse : 58 : 325 : Click : 0 : 0 : 0
DELAY : 500
LABEL : Start-Up video
COMMENT : Start upload video
COMMENT : Click TAO button
Mouse : 1264 : 128 : Click : 0 : 0 : 0
DELAY : 300
COMMENT : Click up button
Mouse : 1232 : 158 : Click : 0 : 0 : 0
DELAY : 300
COMMENT : Determine the correct folder
SWITCH TO WINDOW : RandomFile : 0
DELAY : 100
Mouse : 316 : 129 : Click : 0 : 0 : 0
DELAY : 30
Keyboard : ControlLeft : KeyDown
Keyboard : A : KeyDown
DELAY : 100
Keyboard : ControlLeft : KeyUp
Keyboard : A : KeyUp
DELAY : 100
Keyboard : ControlLeft : KeyDown
Keyboard : C : KeyDown
DELAY : 100
Keyboard : ControlLeft : KeyUp
Keyboard : C : KeyUp
DELAY : 100
SWITCH TO WINDOW : Trang tổng quan của kênh - YouTube Studio - Google Chrome : 0
DELAY : 100
COMMENT : Click chon tai video
LABEL : Chon video
Mouse : 666 : 508 : Click : 0 : 0 : 0
DELAY : 700
COMMENT : Select add bar
Mouse : 843 : 55 : Click : 0 : 0 : 0
DELAY : 150
COMMENT : Paste to add bar
PASTE
DELAY : 160
Keyboard : Enter : KeyPress
DELAY : 80
COMMENT : Click the win dow prepare select all
Mouse : 203 : 540 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Control ALL-chon het
Keyboard : ControlLeft : KeyDown
DELAY : 20
Keyboard : A : KeyDown
DELAY : 20
Keyboard : ControlLeft : KeyUp
Keyboard : A : KeyUp
DELAY : 20
COMMENT : Enter
Keyboard : Enter : KeyPress
DELAY : 20
COMMENT : waiting for upload video
DELAY : 60000
COMMENT : Check upload file ok or not
IF PIXEL COLOR EQUALS : 713 : 520 : 4105983 : 0
COMMENT : More delay
DELAY : 60000
GOTO : Chon video
ENDIF
COMMENT : Create Random file
SWITCH TO WINDOW : RandomFile : 0
Mouse : 71 : 207 : Click : 0 : 0 : 0
DELAY : 20
SWITCH TO WINDOW : Trang tổng quan của kênh - YouTube Studio - Google Chrome : 0
DELAY : 20
COMMENT : Count update time
COMMENT : Change to increase tab
Mouse : 270 : 21 : Click : 0 : 0 : 0
DELAY : 20
COMMENT : Click to increase time up video
Mouse : 277 : 557 : Click : 0 : 0 : 0
DELAY : 70
IF CLIPBOARD EQUALS : EndUpVideo : 0 : 0
COMMENT : Full video for channel of ths turn
ENDIF
IF CLIPBOARD EQUALS : NextNewChannel : 0 : 0
GOTO : Start
COMMENT : Full video for channel of ths turn
ENDIF
COMMENT : Back to YT tab
Mouse : 38 : 16 : Click : 0 : 0 : 0
DELAY : 20
COMMENT : End-Count update time
GOTO : Start-Up video
