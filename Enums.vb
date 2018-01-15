Module Enums

    Enum ERRORS
        ERROR_OK = &H0
        ERROR_CHECKSUM_WRONG = &H1
        ERROR_WRONG_CHARACTER_FOUND = &H2
        ERROR_WRONG_PACKET_LENGTH = &H3
        ERROR_WRONG_KEY = &H4
        ERROR_UNKNOWN_COMMAND = &H5

    End Enum

    Enum OFFSETS
        OFFSET_KEY = 0
        OFFSET_CHECKSUM = 1
        OFFSET_LENGTH = 3
        OFFSET_ERROR = 5
        OFFSET_COMMAND = 7
    End Enum


   

End Module
