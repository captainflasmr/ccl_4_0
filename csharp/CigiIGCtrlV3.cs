//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiIGCtrlV3 : CigiBaseIGCtrl {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiIGCtrlV3(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiIGCtrlV3_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiIGCtrlV3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiIGCtrlV3 obj) {
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
          ccl_dllDPINVOKE.delete_CigiIGCtrlV3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiIGCtrlV3() : this(ccl_dllDPINVOKE.new_CigiIGCtrlV3(), true) {
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public int SetFrameCntr(SWIGTYPE_p_unsigned___int32 FrameCntrIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetFrameCntr__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(FrameCntrIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFrameCntr(SWIGTYPE_p_unsigned___int32 FrameCntrIn) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetFrameCntr__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(FrameCntrIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int32 GetTimeStamp() {
    SWIGTYPE_p_unsigned___int32 ret = new SWIGTYPE_p_unsigned___int32(ccl_dllDPINVOKE.CigiIGCtrlV3_GetTimeStamp(swigCPtr), true);
    return ret;
  }

  public int SetTimeStamp(SWIGTYPE_p_unsigned___int32 TimeStamp, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetTimeStamp__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(TimeStamp), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetTimeStamp(SWIGTYPE_p_unsigned___int32 TimeStamp) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetTimeStamp__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(TimeStamp));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTimeStampValid() {
    bool ret = ccl_dllDPINVOKE.CigiIGCtrlV3_GetTimeStampValid(swigCPtr);
    return ret;
  }

  public int SetTimeStampValid(bool TimeStampValidIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetTimeStampValid__SWIG_0(swigCPtr, TimeStampValidIn, bndchk);
    return ret;
  }

  public int SetTimeStampValid(bool TimeStampValidIn) {
    int ret = ccl_dllDPINVOKE.CigiIGCtrlV3_SetTimeStampValid__SWIG_1(swigCPtr, TimeStampValidIn);
    return ret;
  }

}
