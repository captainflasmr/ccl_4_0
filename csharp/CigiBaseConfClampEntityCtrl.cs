//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiBaseConfClampEntityCtrl : CigiBasePacket {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiBaseConfClampEntityCtrl(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiBaseConfClampEntityCtrl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiBaseConfClampEntityCtrl obj) {
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
          ccl_dllDPINVOKE.delete_CigiBaseConfClampEntityCtrl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetCnvt(CigiVersionID CnvtVersion, SWIGTYPE_p_CigiCnvtInfoType__Type CnvtInfo) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_GetCnvt(swigCPtr, CigiVersionID.getCPtr(CnvtVersion), SWIGTYPE_p_CigiCnvtInfoType__Type.getCPtr(CnvtInfo));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetEntityID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetEntityID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int16 GetEntityID() {
    SWIGTYPE_p_unsigned___int16 ret = new SWIGTYPE_p_unsigned___int16(ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_GetEntityID(swigCPtr), true);
    return ret;
  }

  public int SetYaw(float YawIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetYaw__SWIG_0(swigCPtr, YawIn, bndchk);
    return ret;
  }

  public int SetYaw(float YawIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetYaw__SWIG_1(swigCPtr, YawIn);
    return ret;
  }

  public float GetYaw() {
    float ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_GetYaw(swigCPtr);
    return ret;
  }

  public int SetLat(double LatIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetLat__SWIG_0(swigCPtr, LatIn, bndchk);
    return ret;
  }

  public int SetLat(double LatIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetLat__SWIG_1(swigCPtr, LatIn);
    return ret;
  }

  public double GetLat() {
    double ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_GetLat(swigCPtr);
    return ret;
  }

  public int SetLon(double LonIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetLon__SWIG_0(swigCPtr, LonIn, bndchk);
    return ret;
  }

  public int SetLon(double LonIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_SetLon__SWIG_1(swigCPtr, LonIn);
    return ret;
  }

  public double GetLon() {
    double ret = ccl_dllDPINVOKE.CigiBaseConfClampEntityCtrl_GetLon(swigCPtr);
    return ret;
  }

}
