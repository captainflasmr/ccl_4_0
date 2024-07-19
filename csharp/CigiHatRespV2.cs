//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiHatRespV2 : CigiBaseHatHotResp {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiHatRespV2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiHatRespV2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiHatRespV2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiHatRespV2 obj) {
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
          ccl_dllDPINVOKE.delete_CigiHatRespV2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiHatRespV2() : this(ccl_dllDPINVOKE.new_CigiHatRespV2(), true) {
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetCnvt(CigiVersionID CnvtVersion, SWIGTYPE_p_CigiCnvtInfoType__Type CnvtInfo) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_GetCnvt(swigCPtr, CigiVersionID.getCPtr(CnvtVersion), SWIGTYPE_p_CigiCnvtInfoType__Type.getCPtr(CnvtInfo));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetHat(double HatIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_SetHat__SWIG_0(swigCPtr, HatIn, bndchk);
    return ret;
  }

  public int SetHat(double HatIn) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_SetHat__SWIG_1(swigCPtr, HatIn);
    return ret;
  }

  public double GetHat() {
    double ret = ccl_dllDPINVOKE.CigiHatRespV2_GetHat(swigCPtr);
    return ret;
  }

  public int SetMaterial(SWIGTYPE_p_unsigned___int32 MaterialIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_SetMaterial__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(MaterialIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetMaterial(SWIGTYPE_p_unsigned___int32 MaterialIn) {
    int ret = ccl_dllDPINVOKE.CigiHatRespV2_SetMaterial__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(MaterialIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int32 GetMaterial() {
    SWIGTYPE_p_unsigned___int32 ret = new SWIGTYPE_p_unsigned___int32(ccl_dllDPINVOKE.CigiHatRespV2_GetMaterial(swigCPtr), true);
    return ret;
  }

}
