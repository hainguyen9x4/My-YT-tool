LABEL : Start
DELAY : 700
COMMENT : Chon filter
Mouse : 514 : 388 : Click : 0 : 0 : 0
DELAY : 600
COMMENT : Apply ban nhap
Mouse : 555 : 666 : Click : 0 : 0 : 0
DELAY : 2300
COMMENT : Chinh sua ban nhap
Mouse : 1776 : 491 : Click : 0 : 0 : 0
DELAY : 2000
CLEAR CLIPBOARD
COMMENT : Copy link of YT video
Mouse : 1418 : 664 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Check clip Board
IF CLIPBOARD EQUALS : https://youtu.be/ : 0 : 1
ELSE
COMMENT : if not youtube link
COMMENT : Go to chanel
Mouse : 244 : 125 : Click : 0 : 0 : 0
DELAY : 7000
GOTO : Start
ENDIF
COMMENT : Tiep 1
Mouse : 1450 : 940 : Click : 0 : 0 : 0
DELAY : 400
COMMENT : Tiep2
Mouse : 1450 : 940 : Click : 0 : 0 : 0
DELAY : 400
COMMENT : Tiep3
Mouse : 1450 : 940 : Click : 0 : 0 : 0
COMMENT : Len lich
DELAY : 400
Mouse : 507 : 832 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : tab Increase
Mouse : 591 : 0 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Copy day
Mouse : 395 : 287 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Return YT tab
Mouse : 243 : 0 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Open canladar
Mouse : 614 : 686 : Click : 0 : 0 : 0
COMMENT : next-month
PLAY MACRO : D:\Youtube\My-YT-tool\Macro-ThinkPad\next-month.mcr
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
DELAY : 5500
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
COMMENT : Go to chanel
Mouse : 244 : 125 : Click : 0 : 0 : 0
DELAY : 10000
ENDIF
