COMMENT : Prepare random file
DELAY : 100
SWITCH TO WINDOW : RandomFile : 0
DELAY : 20
COMMENT : Click drop box
Mouse : 397 : 69 : Click : 0 : 0 : 0
DELAY : 30
COMMENT : if channel is Smile
IF CLIPBOARD EQUALS : Smile : 0 : 1
COMMENT : Click smile channel
Mouse : 160 : 87 : Click : 0 : 0 : 0
DELAY : 30
ENDIF
COMMENT : if channel is Animation
IF CLIPBOARD EQUALS : Animation : 0 : 1
COMMENT : Click Animation channel
Mouse : 118 : 99 : Click : 0 : 0 : 0
DELAY : 30
ENDIF
COMMENT : if channel is Funny
IF CLIPBOARD EQUALS : Funny : 0 : 1
COMMENT : Click Funny channel
Mouse : 115 : 113 : Click : 0 : 0 : 0
DELAY : 30
ENDIF
COMMENT : if channel is Animal
IF CLIPBOARD EQUALS : Animal : 0 : 1
COMMENT : Click Animal channel
Mouse : 108 : 127 : Click : 0 : 0 : 0
DELAY : 30
ENDIF
COMMENT : if channel is Hot
IF CLIPBOARD EQUALS : Hot : 0 : 1
COMMENT : Click Hot channel
Mouse : 101 : 137 : Click : 0 : 0 : 0
DELAY : 700
ENDIF
COMMENT : Click execute
Mouse : 66 : 203 : Click : 0 : 0 : 0
DELAY : 30
SWITCH TO WINDOW : Trang tổng quan của kênh - YouTube Studio - Google Chrome : 0
DELAY : 100
COMMENT : END_Prepare random file
