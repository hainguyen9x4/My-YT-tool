LABEL : Start
DELAY : 250
COMMENT : Go to YT tab
Mouse : 38 : 19 : Click : 0 : 0 : 0
DELAY : 250
COMMENT : Chon filter
Mouse : 356 : 262 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Apply ban nhap
Mouse : 354 : 445 : Click : 0 : 0 : 0
DELAY : 1300
COMMENT : Chinh sua ban nhap
Mouse : 1265 : 327 : Click : 0 : 0 : 0
DELAY : 3000
CLEAR CLIPBOARD
COMMENT : Check valid-before-pressing-TIEP1
IF PIXEL COLOR EQUALS : 1030 : 676 : 4105983 : 1
COMMENT : Neu khong phai nut TIEP(check color)
COMMENT : Go to right channel
PLAY MACRO : function\correct-the-right-channel.mcr
DELAY : 10000
COMMENT : Count-restart
COMMENT : change to increase tab
Mouse : 277 : 18 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Click count
Mouse : 27 : 560 : Click : 0 : 0 : 0
DELAY : 50
IF CLIPBOARD EQUALS : NOT VALID! : 0 : 0
SHUTDOWN : 1
ENDIF
COMMENT : Re-start-command
DELAY : 500
GOTO : Start
ENDIF
COMMENT : Clear count re-start
COMMENT : Go to increase tab
Mouse : 267 : 15 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Clear count re-start
Mouse : 130 : 559 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Return YT tab
Mouse : 30 : 13 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Tiep 1
Mouse : 1013 : 672 : Click : 0 : 0 : 0
DELAY : 350
COMMENT : Tiep2
Mouse : 1012 : 670 : Click : 0 : 0 : 0
DELAY : 350
COMMENT : Tiep3
Mouse : 1008 : 671 : Click : 0 : 0 : 0
COMMENT : Len lich
DELAY : 150
Mouse : 384 : 555 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Open canladar
Mouse : 493 : 453 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Get Number count for next month
COMMENT : Go to Increase tab
Mouse : 273 : 19 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Determine the number next month
Mouse : 116 : 370 : Click : 0 : 0 : 0
DELAY : 90
COMMENT : Go back to TY tab
Mouse : 38 : 16 : Click : 0 : 0 : 0
DELAY : 90
REPEAT : 4 : 0 : 1 : Enter the number of iterations: : 0 : 0
COMMENT : next-month
PLAY MACRO : function\next-month.mcr
ENDREPEAT
COMMENT : tab Increase
Mouse : 268 : 14 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Copy day
Mouse : 245 : 196 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Return YT tab
Mouse : 23 : 21 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Select day from clipboard
PLAY MACRO : function\Select-Day-From-ClipBoard.mcr
COMMENT : Change to increase tab
Mouse : 280 : 22 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Copy time
Mouse : 202 : 141 : Click : 0 : 0 : 0
DELAY : 100
IF CLIPBOARD EQUALS : 24 : 0 : 0
COMMENT : Re-copy day
Mouse : 241 : 197 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Check is Day =32
IF CLIPBOARD EQUALS : 32 : 0 : 0
COMMENT : Check turn off or not
Mouse : 78 : 520 : Click : 0 : 0 : 0
DELAY : 100
IF CLIPBOARD EQUALS : TURN OFF : 0 : 0
SHUTDOWN : 1
ENDIF
ENDIF
COMMENT : Return YT tab
Mouse : 43 : 18 : Click : 0 : 0 : 0
DELAY : 10
COMMENT : Open canladar
Mouse : 489 : 460 : Click : 0 : 0 : 0
COMMENT : Select day from clipboard
PLAY MACRO : function\Select-Day-From-ClipBoard.mcr
COMMENT : Change to increase tab
Mouse : 269 : 17 : Click : 0 : 0 : 0
DELAY : 100
COMMENT : Copy time
Mouse : 209 : 140 : Click : 0 : 0 : 0
DELAY : 100
ENDIF
COMMENT : Return YT tab
Mouse : 36 : 19 : Click : 0 : 0 : 0
COMMENT : select time
PLAY MACRO : function\Select-time-From-ClipBoard.mcr
COMMENT : LEN LICH
Mouse : 987 : 677 : Click : 0 : 0 : 0
DELAY : 2000
REPEAT : 7 : 0 : 0 : Enter the number of iterations: : 0 : 0
COMMENT : Copy link of YT video
CLEAR CLIPBOARD
Mouse : 826 : 480 : Click : 0 : 0 : 0
DELAY : 50
COMMENT : Check clip Board
IF CLIPBOARD EQUALS : https : 0 : 1
COMMENT : CLOSE-Dong
Mouse : 837 : 519 : Click : 0 : 0 : 0
DELAY : 50
EXIT LOOP
ENDIF
DELAY : 1000
IF ITERATION EQUALS : 7 : 0
COMMENT : if not youtube link
COMMENT : Go to right channel
PLAY MACRO : function\correct-the-right-channel.mcr
DELAY : 10000
ENDIF
ENDREPEAT
GOTO : Start
