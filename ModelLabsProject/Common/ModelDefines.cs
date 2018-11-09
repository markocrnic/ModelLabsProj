using System;
using System.Collections.Generic;
using System.Text;

namespace FTN.Common
{
	
	public enum DMSType : short
	{		
		MASK_TYPE							= unchecked((short)0xFFFF),

		CONNODE			    				= 0x0001,
        PLSIMPEDANCE                        = 0x0002,
        SERIESCOMP							= 0x0003,
		DCLSEGMENT						    = 0x0004,
		ACLSEGMENT							= 0x0005,
        TERMINAL                            = 0x0006,
    }

    [Flags]
	public enum ModelCode : long
	{
		IDOBJ								= 0x1000000000000000,
		IDOBJ_GID							= 0x1000000000000104,	

		PSR									= 0x1100000000000000,

        TERMINAL                            = 0x1200000000060000,
        TERMINAL_CONNODE                    = 0x1200000000060109,
        TERMINAL_CONDEQ                     = 0x1200000000060209,

        CONNODE                             = 0x1300000000010000,
        CONNODE_DESC                        = 0x1300000000010107,
        CONNODE_TERMINALS                   = 0x1300000000010219,

        PLIMPEDANCE                         = 0x1400000000000000,
        PLIMPEDANCE_ACLSEGMENTS             = 0x1400000000000119,

        EQUIPMENT                           = 0x1110000000000000,

		CONDEQ								= 0x1111000000000000,
        CONDEQ_TERMINALS                    = 0x1111000000000119,

        SERIESCOMP                          = 0x1111200000030000,
        SERIESCOMP_R                        = 0x1111200000030105,
        SERIESCOMP_R0                       = 0x1111200000030205,
        SERIESCOMP_X                        = 0x1111200000030305,
        SERIESCOMP_X0                       = 0x1111200000030405,

        CONDUCTOR                           = 0x1111100000000000,
        CONDUCTOR_LENGTH                    = 0x1111100000000105,

        DCLSEGMENT                          = 0x1111110000040000,

        ACLSEGMENT                          = 0x1111120000050000,
        ACLSEGMENT_B0CH                     = 0x1111120000050105,
        ACLSEGMENT_BCH                      = 0x1111120000050205,
        ACLSEGMENT_G0CH                     = 0x1111120000050305,
        ACLSEGMENT_GCH                      = 0x1111120000050405,
        ACLSEGMENT_R                        = 0x1111120000050505,
        ACLSEGMENT_R0                       = 0x1111120000050605,
        ACLSEGMENT_X                        = 0x1111120000050705,
        ACLSEGMENT_X0                       = 0x1111120000050805,
        ACLSEGMENT_PLIMPEDANCE              = 0x1111120000050909,

        PLSIMPEDANCE                        = 0x1410000000020000,
        PLSIMPEDANCE_B0CH                   = 0x1410000000020105,
        PLSIMPEDANCE_BCH                    = 0x1410000000020205,
        PLSIMPEDANCE_G0CH                   = 0x1410000000020305,
        PLSIMPEDANCE_GCH                    = 0x1410000000020405,
        PLSIMPEDANCE_R                      = 0x1410000000020505,
        PLSIMPEDANCE_R0                     = 0x1410000000020605,
        PLSIMPEDANCE_X                      = 0x1410000000020705,
        PLSIMPEDANCE_X0                     = 0x1410000000020805,
    }

    [Flags]
	public enum ModelCodeMask : long
	{
		MASK_TYPE			 = 0x00000000ffff0000,
		MASK_ATTRIBUTE_INDEX = 0x000000000000ff00,
		MASK_ATTRIBUTE_TYPE	 = 0x00000000000000ff,

		MASK_INHERITANCE_ONLY = unchecked((long)0xffffffff00000000),
		MASK_FIRSTNBL		  = unchecked((long)0xf000000000000000),
		MASK_DELFROMNBL8	  = unchecked((long)0xfffffff000000000),		
	}																		
}


