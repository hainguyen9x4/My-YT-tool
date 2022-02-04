LABEL : Start
DELAY : 500
COMMENT : Chon filter
Mouse : 514 : 388 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Apply ban nhap
Mouse : 555 : 666 : Click : 0 : 0 : 0
DELAY : 1300
COMMENT : Chinh sua ban nhap
Mouse : 1776 : 491 : Click : 0 : 0 : 0
DELAY : 1500
CLEAR CLIPBOARD
COMMENT : Copy link of YT video
Mouse : 1418 : 664 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Check clip Board
IF CLIPBOARD EQUALS : https://youtu.be/ : 0 : 1
ELSE
COMMENT : if not youtube link
COMMENT : Go to right channel
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\correct-the-right-channel.mcr
DELAY : 7000
GOTO : Start
ENDIF
COMMENT : Tiep 1
Mouse : 1450 : 940 : Click : 0 : 0 : 0
DELAY : 350
COMMENT : Tiep2
Mouse : 1450 : 940 : Click : 0 : 0 : 0
DELAY : 350
COMMENT : Tiep3
Mouse : 1450 : 940 : Click : 0 : 0 : 0
COMMENT : Len lich
DELAY : 350
Mouse : 507 : 832 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Open canladar
Mouse : 614 : 686 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Get Number count for next month
COMMENT : Go to Increase tab
Mouse : 401 : 25 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Determine the number next month
Mouse : 163 : 553 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Go back to TY tab
Mouse : 43 : 22 : Click : 0 : 0 : 0
DELAY : 90
REPEAT : 0 : 0 : 1 : Enter the number of iterations: : 0 : 0
COMMENT : next-month
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\next-month.mcr
ENDREPEAT
COMMENT : tab Increase
Mouse : 591 : 0 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Copy day
Mouse : 395 : 287 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Return YT tab
Mouse : 243 : 0 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Select day from clipboard
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\Select-Day-From-ClipBoard.mcr
COMMENT : Change to increase tab
Mouse : 516 : 17 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Copy time
Mouse : 417 : 213 : Click : 0 : 0 : 0
DELAY : 100
IF CLIPBOARD EQUALS : 24 : 0 : 0
COMMENT : Re-copy day
Mouse : 357 : 296 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Check is Day =32
IF CLIPBOARD EQUALS : 32 : 0 : 0
Mouse : 123 : 639 : Click : 0 : 0 : 0
DELAY : 100
IF CLIPBOARD EQUALS : TURN OFF : 0 : 0
SHUTDOWN : 1
ENDIF
ENDIF
COMMENT : Return YT tab
Mouse : 168 : 17 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Open canladar
Mouse : 685 : 680 : Click : 0 : 0 : 0
COMMENT : Select day from clipboard
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\Select-Day-From-ClipBoard.mcr
COMMENT : Change to increase tab
Mouse : 516 : 17 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Copy time
Mouse : 417 : 213 : Click : 0 : 0 : 0
DELAY : 100
ENDIF
COMMENT : Return YT tab
Mouse : 168 : 17 : Click : 0 : 0 : 0
COMMENT : select time
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\Select-time-From-ClipBoard.mcr
COMMENT : Len lich
Mouse : 1427 : 937 : Click : 0 : 0 : 0
DELAY : 4000
CLEAR CLIPBOARD
COMMENT : Copy link of YT video
Mouse : 1174 : 684 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Check clip Board
IF CLIPBOARD EQUALS : https://youtu.be/ : 0 : 1
COMMENT : CLOSE-Dong
Mouse : 1201 : 742 : Click : 0 : 0 : 0
ELSE
COMMENT : if not youtube link
COMMENT : Go to right channel
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\correct-the-right-channel.mcr
DELAY : 10000
ENDIF
