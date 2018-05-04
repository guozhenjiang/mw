#define CRC_16_POLYNOMIALS            0x8005	// 多项式0x8005的含义是： x^15 + x^2 + 1

unsigned short CRC16_3(unsigned char* pchMsg, unsigned short wDataLen) // 1. MSB first; 2. Initial value is 0000;
{
    unsigned char i, chChar;
    unsigned short wCRC = 0;
	
    while(wDataLen--)
    {
        chChar = *pchMsg++;        
        wCRC ^= (((unsigned short) chChar) << 8);
		
        for(i=0; i<8; i++)
        {
            if(wCRC & 0x8000)
                wCRC = (wCRC << 1) ^ CRC_16_POLYNOMIALS;
            else
                wCRC <<= 1;
        }
    }
    
    return wCRC;
}