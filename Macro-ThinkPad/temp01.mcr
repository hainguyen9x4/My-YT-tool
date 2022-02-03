COMMENT : Change tab Increase
Mouse : 415 : 26 : Click : 0 : 0 : 0
DELAY : 100
LABEL : Copy-check-Value
COMMENT : Copy value check
Mouse : 315 : 443 : Click : 0 : 0 : 0
DELAY : 100
IF CLIPBOARD EQUALS : 2022 : 0 : 0
ELSE
COMMENT : Close tab that not Increase
Mouse : 701 : 29 : Click : 0 : 0 : 0
DELAY : 100
GOTO : Copy-check-Value
ENDIF
