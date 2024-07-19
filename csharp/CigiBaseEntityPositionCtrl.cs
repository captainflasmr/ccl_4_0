//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiBaseEntityPositionCtrl : CigiBasePacket {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiBaseEntityPositionCtrl(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiBaseEntityPositionCtrl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiBaseEntityPositionCtrl obj) {
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
          ccl_dllDPINVOKE.delete_CigiBaseEntityPositionCtrl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetCnvt(CigiVersionID CnvtVersion, SWIGTYPE_p_CigiCnvtInfoType__Type CnvtInfo) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetCnvt(swigCPtr, CigiVersionID.getCPtr(CnvtVersion), SWIGTYPE_p_CigiCnvtInfoType__Type.getCPtr(CnvtInfo));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetEntityID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetEntityID(SWIGTYPE_p_unsigned___int16 EntityIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetEntityID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(EntityIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int16 GetEntityID() {
    SWIGTYPE_p_unsigned___int16 ret = new SWIGTYPE_p_unsigned___int16(ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetEntityID(swigCPtr), true);
    return ret;
  }

  public int SetParentID(SWIGTYPE_p_unsigned___int16 ParentIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetParentID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(ParentIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetParentID(SWIGTYPE_p_unsigned___int16 ParentIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetParentID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(ParentIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int16 GetParentID() {
    SWIGTYPE_p_unsigned___int16 ret = new SWIGTYPE_p_unsigned___int16(ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetParentID(swigCPtr), true);
    return ret;
  }

  public int SetAttachState(CigiBaseEntityPositionCtrl.AttachStateGrp AttachStateIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetAttachState__SWIG_0(swigCPtr, (int)AttachStateIn, bndchk);
    return ret;
  }

  public int SetAttachState(CigiBaseEntityPositionCtrl.AttachStateGrp AttachStateIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetAttachState__SWIG_1(swigCPtr, (int)AttachStateIn);
    return ret;
  }

  public CigiBaseEntityPositionCtrl.AttachStateGrp GetAttachState() {
    CigiBaseEntityPositionCtrl.AttachStateGrp ret = (CigiBaseEntityPositionCtrl.AttachStateGrp)ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetAttachState(swigCPtr);
    return ret;
  }

  public int SetClampState(CigiBaseEntityPositionCtrl.ClampStateGrp ClampStateIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetClampState__SWIG_0(swigCPtr, (int)ClampStateIn, bndchk);
    return ret;
  }

  public int SetClampState(CigiBaseEntityPositionCtrl.ClampStateGrp ClampStateIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetClampState__SWIG_1(swigCPtr, (int)ClampStateIn);
    return ret;
  }

  public CigiBaseEntityPositionCtrl.ClampStateGrp GetClampState() {
    CigiBaseEntityPositionCtrl.ClampStateGrp ret = (CigiBaseEntityPositionCtrl.ClampStateGrp)ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetClampState(swigCPtr);
    return ret;
  }

  public int SetPitch(float PitchIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetPitch__SWIG_0(swigCPtr, PitchIn, bndchk);
    return ret;
  }

  public int SetPitch(float PitchIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetPitch__SWIG_1(swigCPtr, PitchIn);
    return ret;
  }

  public float GetPitch() {
    float ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetPitch(swigCPtr);
    return ret;
  }

  public int SetRoll(float RollIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetRoll__SWIG_0(swigCPtr, RollIn, bndchk);
    return ret;
  }

  public int SetRoll(float RollIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetRoll__SWIG_1(swigCPtr, RollIn);
    return ret;
  }

  public float GetRoll() {
    float ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetRoll(swigCPtr);
    return ret;
  }

  public int SetYaw(float YawIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetYaw__SWIG_0(swigCPtr, YawIn, bndchk);
    return ret;
  }

  public int SetYaw(float YawIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetYaw__SWIG_1(swigCPtr, YawIn);
    return ret;
  }

  public float GetYaw() {
    float ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetYaw(swigCPtr);
    return ret;
  }

  public int SetXoff(double Xoff, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetXoff__SWIG_0(swigCPtr, Xoff, bndchk);
    return ret;
  }

  public int SetXoff(double Xoff) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetXoff__SWIG_1(swigCPtr, Xoff);
    return ret;
  }

  public double GetXoff() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetXoff(swigCPtr);
    return ret;
  }

  public int SetYoff(double Yoff, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetYoff__SWIG_0(swigCPtr, Yoff, bndchk);
    return ret;
  }

  public int SetYoff(double Yoff) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetYoff__SWIG_1(swigCPtr, Yoff);
    return ret;
  }

  public double GetYoff() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetYoff(swigCPtr);
    return ret;
  }

  public int SetZoff(double Zoff, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetZoff__SWIG_0(swigCPtr, Zoff, bndchk);
    return ret;
  }

  public int SetZoff(double Zoff) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetZoff__SWIG_1(swigCPtr, Zoff);
    return ret;
  }

  public double GetZoff() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetZoff(swigCPtr);
    return ret;
  }

  public int SetLat(double Lat, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetLat__SWIG_0(swigCPtr, Lat, bndchk);
    return ret;
  }

  public int SetLat(double Lat) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetLat__SWIG_1(swigCPtr, Lat);
    return ret;
  }

  public double GetLat() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetLat(swigCPtr);
    return ret;
  }

  public int SetLon(double Lon, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetLon__SWIG_0(swigCPtr, Lon, bndchk);
    return ret;
  }

  public int SetLon(double Lon) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetLon__SWIG_1(swigCPtr, Lon);
    return ret;
  }

  public double GetLon() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetLon(swigCPtr);
    return ret;
  }

  public int SetAlt(double Alt, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetAlt__SWIG_0(swigCPtr, Alt, bndchk);
    return ret;
  }

  public int SetAlt(double Alt) {
    int ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_SetAlt__SWIG_1(swigCPtr, Alt);
    return ret;
  }

  public double GetAlt() {
    double ret = ccl_dllDPINVOKE.CigiBaseEntityPositionCtrl_GetAlt(swigCPtr);
    return ret;
  }

  public enum AttachStateGrp {
    Detach = 0,
    Attach = 1
  }

  public enum ClampStateGrp {
    NoClamp = 0,
    AltClamp = 1,
    AltAttClamp = 2
  }

}
