//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiLosVectReqV3 : CigiBaseLosVectReq {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiLosVectReqV3(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiLosVectReqV3_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiLosVectReqV3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiLosVectReqV3 obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ccl_dllDPINVOKE.delete_CigiLosVectReqV3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiLosVectReqV3() : this(ccl_dllDPINVOKE.new_CigiLosVectReqV3(), true) {
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public int SetReqType(CigiBaseLosVectReq.ReqTypeGrp ReqTypeIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetReqType__SWIG_0(swigCPtr, (int)ReqTypeIn, bndchk);
    return ret;
  }

  public int SetReqType(CigiBaseLosVectReq.ReqTypeGrp ReqTypeIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetReqType__SWIG_1(swigCPtr, (int)ReqTypeIn);
    return ret;
  }

  public CigiBaseLosVectReq.ReqTypeGrp GetReqType() {
    CigiBaseLosVectReq.ReqTypeGrp ret = (CigiBaseLosVectReq.ReqTypeGrp)ccl_dllDPINVOKE.CigiLosVectReqV3_GetReqType(swigCPtr);
    return ret;
  }

  public int SetSrcCoordSys(CigiBaseLosVectReq.CoordSysGrp SrcCoordSysIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcCoordSys__SWIG_0(swigCPtr, (int)SrcCoordSysIn, bndchk);
    return ret;
  }

  public int SetSrcCoordSys(CigiBaseLosVectReq.CoordSysGrp SrcCoordSysIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcCoordSys__SWIG_1(swigCPtr, (int)SrcCoordSysIn);
    return ret;
  }

  public CigiBaseLosVectReq.CoordSysGrp GetSrcCoordSys() {
    CigiBaseLosVectReq.CoordSysGrp ret = (CigiBaseLosVectReq.CoordSysGrp)ccl_dllDPINVOKE.CigiLosVectReqV3_GetSrcCoordSys(swigCPtr);
    return ret;
  }

  public int SetResponseCoordSys(CigiBaseLosVectReq.CoordSysGrp ResponseCoordSysIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetResponseCoordSys__SWIG_0(swigCPtr, (int)ResponseCoordSysIn, bndchk);
    return ret;
  }

  public int SetResponseCoordSys(CigiBaseLosVectReq.CoordSysGrp ResponseCoordSysIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetResponseCoordSys__SWIG_1(swigCPtr, (int)ResponseCoordSysIn);
    return ret;
  }

  public CigiBaseLosVectReq.CoordSysGrp GetResponseCoordSys() {
    CigiBaseLosVectReq.CoordSysGrp ret = (CigiBaseLosVectReq.CoordSysGrp)ccl_dllDPINVOKE.CigiLosVectReqV3_GetResponseCoordSys(swigCPtr);
    return ret;
  }

  public int SetAlphaThresh(SWIGTYPE_p_unsigned___int8 AlphaThreshIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetAlphaThresh__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(AlphaThreshIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetAlphaThresh(SWIGTYPE_p_unsigned___int8 AlphaThreshIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetAlphaThresh__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(AlphaThreshIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int8 GetAlphaThresh() {
    SWIGTYPE_p_unsigned___int8 ret = new SWIGTYPE_p_unsigned___int8(ccl_dllDPINVOKE.CigiLosVectReqV3_GetAlphaThresh(swigCPtr), true);
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetEntityID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetEntityID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int16 GetEntityID() {
    SWIGTYPE_p_unsigned___int16 ret = new SWIGTYPE_p_unsigned___int16(ccl_dllDPINVOKE.CigiLosVectReqV3_GetEntityID(swigCPtr), true);
    return ret;
  }

  public int SetVectAz(float VectAzIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetVectAz__SWIG_0(swigCPtr, VectAzIn, bndchk);
    return ret;
  }

  public int SetVectAz(float VectAzIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetVectAz__SWIG_1(swigCPtr, VectAzIn);
    return ret;
  }

  public float GetVectAz() {
    float ret = ccl_dllDPINVOKE.CigiLosVectReqV3_GetVectAz(swigCPtr);
    return ret;
  }

  public int SetMinRange(float MinRangeIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetMinRange__SWIG_0(swigCPtr, MinRangeIn, bndchk);
    return ret;
  }

  public int SetMinRange(float MinRangeIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetMinRange__SWIG_1(swigCPtr, MinRangeIn);
    return ret;
  }

  public float GetMinRange() {
    float ret = ccl_dllDPINVOKE.CigiLosVectReqV3_GetMinRange(swigCPtr);
    return ret;
  }

  public int SetSrcXoff(double SrcXoffIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcXoff__SWIG_0(swigCPtr, SrcXoffIn, bndchk);
    return ret;
  }

  public int SetSrcXoff(double SrcXoffIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcXoff__SWIG_1(swigCPtr, SrcXoffIn);
    return ret;
  }

  public double GetSrcXoff() {
    double ret = ccl_dllDPINVOKE.CigiLosVectReqV3_GetSrcXoff(swigCPtr);
    return ret;
  }

  public int SetSrcYoff(double SrcYoffIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcYoff__SWIG_0(swigCPtr, SrcYoffIn, bndchk);
    return ret;
  }

  public int SetSrcYoff(double SrcYoffIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcYoff__SWIG_1(swigCPtr, SrcYoffIn);
    return ret;
  }

  public double GetSrcYoff() {
    double ret = ccl_dllDPINVOKE.CigiLosVectReqV3_GetSrcYoff(swigCPtr);
    return ret;
  }

  public int SetSrcZoff(double SrcZoffIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcZoff__SWIG_0(swigCPtr, SrcZoffIn, bndchk);
    return ret;
  }

  public int SetSrcZoff(double SrcZoffIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetSrcZoff__SWIG_1(swigCPtr, SrcZoffIn);
    return ret;
  }

  public double GetSrcZoff() {
    double ret = ccl_dllDPINVOKE.CigiLosVectReqV3_GetSrcZoff(swigCPtr);
    return ret;
  }

  public int SetMask(SWIGTYPE_p_unsigned___int32 MaskIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetMask__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(MaskIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetMask(SWIGTYPE_p_unsigned___int32 MaskIn) {
    int ret = ccl_dllDPINVOKE.CigiLosVectReqV3_SetMask__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(MaskIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int32 GetMask() {
    SWIGTYPE_p_unsigned___int32 ret = new SWIGTYPE_p_unsigned___int32(ccl_dllDPINVOKE.CigiLosVectReqV3_GetMask(swigCPtr), true);
    return ret;
  }

}
