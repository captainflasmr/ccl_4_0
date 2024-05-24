/** <pre>
 *  The SDK is used to create and format CIGI compliant messages.
 *  Copyright (c) 2001-2005 The Boeing Company
 *  
 *  This library is free software; you can redistribute it and/or modify it 
 *  under the terms of the GNU Lesser General Public License as published by 
 *  the Free Software Foundation; either version 2.1 of the License, or (at 
 *  your option) any later version.
 *  
 *  This library is distributed in the hope that it will be useful, but WITHOUT
 *  ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or 
 *  FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser Public License for more 
 *  details.
 *  
 *  You should have received a copy of the GNU Lesser General Public License 
 *  along with this library; if not, write to the Free Software Foundation, 
 *  Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 *  
 *  FILENAME:   CigiCollDetSegRespV4.cpp
 *  LANGUAGE:   C++
 *  CLASS:      UNCLASSIFIED
 *  PROJECT:    Common Image Generator Interface (CIGI) SDK
 *  
 *  PROGRAM DESCRIPTION: 
 *  ...
 *  
 *  MODIFICATION NOTES:
 *  DATE     NAME                                SCR NUMBER
 *  DESCRIPTION OF CHANGE........................
 *  
 *  09/17/2003 Greg Basler                       CIGI_CR_DR_1
 *  Initial Release.
 *  
 *  01/21/2005 Greg Basler                       Version 1.5
 *  Defined _EXPORT_CCL_ for exporting the class in a Windows DLL.
 *  
 *  01/21/2005 Greg Basler                       Version 1.5
 *  Removed the inline defnitions for the PackedPointer union.
 *  
 *  04/14/2006 Greg Basler                       Version 1.7.0
 *  Modified the class constructor to initialize the MinorVersion member 
 *  variable.
 *  
 *  06/23/2006 Greg Basler                       Version 1.7.1
 *  Changed native char and unsigned char types to CIGI types Cigi_int8 and 
 *  Cigi_uint8.
 *  
 *  07/29/2015 Chas Whitley                      Version 4.0.0
 *  Initial Release for CIGI 4.0 compatibility.
 *  Based on CigiCollDetSegRespV3.cpp
 *
 * </pre>
 *  Author: The Boeing Company
 *
 */

#define _EXPORT_CCL_

#include "CigiCollDetSegRespV4.h"
#include "CigiSwapping.h"
#include "CigiExceptions.h"


// ====================================================================
// Construction/Destruction
// ====================================================================


// ================================================
// CigiCollDetSegRespV4
// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
CigiCollDetSegRespV4::CigiCollDetSegRespV4()
{

   PacketID = CIGI_COLL_DET_SEG_RESP_PACKET_ID_V4;
   PacketSize = CIGI_COLL_DET_SEG_RESP_PACKET_SIZE_V4;
   Version = 4;
   MinorVersion = 0;

   EntityID = 0;
   SegID = 0;
   CollType = NonEntity;
   CollEntityID = 0;
   Material = 0;
   IntersectDist = 0.0;
   X = 0.0;
   Y = 0.0;
   Z = 0.0;
   IsValidV1or2 = false;

}

// ================================================
// ~CigiCollDetSegRespV4
// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
CigiCollDetSegRespV4::~CigiCollDetSegRespV4()
{

}

// ====================================================================
// Pack and Unpack
// ====================================================================

// ================================================
// Pack
// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
int CigiCollDetSegRespV4::Pack(CigiBasePacket * Base, Cigi_uint8 * Buff, void *Spec) const
{
   PackPointer CDta;

   CigiBaseCollDetSegResp * Data = ( CigiBaseCollDetSegResp *)Base;

   CDta.c = Buff;

   *CDta.s++ = PacketSize;
   *CDta.s++ = PacketID;

   *CDta.s++ = Data->EntityID;
   *CDta.s++ = Data->CollEntityID;
   *CDta.c++ = Data->SegID;

   *CDta.c++ = ((Cigi_uint8)Data->CollType) & 0x01;

   *CDta.s++ = 0;

   *CDta.l++ = Data->Material;

   if(!Data->IsValidV1or2)
      *CDta.f++ = Data->IntersectDist;
   else
      *CDta.f++ = 0.0f;

   *CDta.l++ = 0;

   return(PacketSize);

}

// ================================================
// Unpack
// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
int CigiCollDetSegRespV4::Unpack(Cigi_uint8 * Buff, bool Swap, void *Spec)
{
   PackPointer CDta;

   CDta.c = Buff;

   CDta.c += 4;  // Step over packet id and size

   if(!Swap)
   {
      EntityID = *CDta.s++;
      CollEntityID = *CDta.s++;
      SegID = *CDta.c++;

      CollType = (CollTypeGrp)(*CDta.c++ & 0x01);

      *CDta.s++;

      Material = *CDta.l++;
      IntersectDist = *CDta.f++;
   }
   else
   {
      CigiSwap2(&EntityID, CDta.s++);
      CigiSwap2(&CollEntityID, CDta.s++);
      SegID = *CDta.c++;

      CollType = (CollTypeGrp)(*CDta.c++ & 0x01);

      *CDta.s++;

      CigiSwap4(&Material, CDta.l++);
      CigiSwap4(&IntersectDist, CDta.f++);
   }

   IsValidV1or2 = false;

   return(PacketSize);

}



// ====================================================================
// Accessors
// ====================================================================


// ================================================
// CollType
// vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
int CigiCollDetSegRespV4::SetCollType(const CollTypeGrp CollTypeIn, bool bndchk)
{

#ifndef CIGI_NO_BND_CHK
   if(bndchk && ((CollTypeIn < 0)||(CollTypeIn > 1)))
   {
#ifndef CIGI_NO_EXCEPT
      throw CigiValueOutOfRangeException("CollType",(CollTypeGrp)CollTypeIn,0,1);
#endif
      return(CIGI_ERROR_VALUE_OUT_OF_RANGE);
   }
#endif

   CollType = CollTypeIn;
   return(CIGI_SUCCESS);

}


