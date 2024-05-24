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
 *  FILENAME:   CigiSymbolTexturedCircleDefV4.h
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
 *  03/11/2008 Greg Basler                       CIGI_SYM_1
 *  Initial Release.
 *  
 *  07/29/2015 Chas Whitley                      Version 4.0.0
 *  Initial Release for CIGI 4.0 compatibility.
 *  Based on CigiSymbolCircleDefV3_3.h
 *  
 * </pre>
 *  Author: The Boeing Company
 *
 */

#if !defined(_CIGI_SYMBOL_TEXTURED_CIRCLE_DEF_V4_INCLUDED_)
#define _CIGI_SYMBOL_TEXTURED_CIRCLE_DEF_V4_INCLUDED_


#include "CigiBaseSymbolTexturedCircleDef.h"
#include "CigiCircleSymbolTextureDataV4.h"



//=========================================================
//! The base class for all packets.
//!
class CIGI_SPEC CigiSymbolTexturedCircleDefV4 :
   public CigiBaseSymbolTexturedCircleDef
{
public:


   //==> Management

   //=========================================================
   //! General Constructor
   //!
   CigiSymbolTexturedCircleDefV4(void);

   //=========================================================
   //! General Destructor
   //!
   virtual ~CigiSymbolTexturedCircleDefV4(void);

   //=========================================================
   //! Copy Constructor
   //!
   CigiSymbolTexturedCircleDefV4(const CigiSymbolTexturedCircleDefV4 &BaseIn);

   //=========================================================
   //! Assignment operator
   //!
   CigiSymbolTexturedCircleDefV4 & operator=(const CigiSymbolTexturedCircleDefV4 &BaseIn);


   //==> Buffer Packing/Unpacking

   //=========================================================
   //! A virtual Pack function.  
   //! \param Base - A pointer to the instance of the packet 
   //!          to be packed. (Downcast to CigiBasePacket)
   //! \param Buff - A pointer to the current pack point.
   //! \param Spec - A pointer to special data.
   //!
   //! \return This returns CIGI_SUCCESS or an error code 
   //!   defined in CigiErrorCodes.h
   //!
   virtual int Pack(CigiBasePacket * Base, Cigi_uint8 * Buff, void *Spec) const;

   //=========================================================
   //! A virtual Unpack function.
   //! \param Buff - A pointer to the current pack point.
   //! \param Swap - N/A for V1 & V2
   //! \param Spec - A pointer to special data.
   //!
   //! \return This returns CIGI_SUCCESS or an error code 
   //!   defined in CigiErrorCodes.h
   //!
   virtual int Unpack(Cigi_uint8 * Buff, bool Swap, void *Spec);


   //+> Circles

   //=========================================================
   //! A virtual Create Circle function.  
   //! This will create a circle object and insert a pointer
   //!   to the created circle object into the Circle Vector.
   //!
   //! \return The pointer to the new circle object.
   //!   If the circle exceeds the maximum number of circles
   //!   or the circle object cannot be created, this will
   //!   return a NULL pointer.
   virtual CigiBaseCircleSymbolTextureData * AddCircle(void);

   //=========================================================
   //! A virtual Remove Circle function.  
   //! This will remove a Circle object from the Circle Vector.
   //! \param CircleIndex - Specifies the index of the desired circle.
   //! \param bndchk - Enables (true) or disables (false) bounds checking.
   //!
   //! \return This returns CIGI_SUCCESS or an error code
   //!   defined in CigiErrorCodes.h
   virtual int RemoveCircle(int CircleIndex, bool bndchk=true);


};



#endif   //  #if !defined(_CIGI_SYMBOL_TEXTURED_CIRCLE_DEF_V4_INCLUDED_)

