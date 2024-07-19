//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiBaseMaritimeSurfaceResp : CigiBasePacket {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiBaseMaritimeSurfaceResp(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiBaseMaritimeSurfaceResp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiBaseMaritimeSurfaceResp obj) {
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
          ccl_dllDPINVOKE.delete_CigiBaseMaritimeSurfaceResp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetCnvt(CigiVersionID CnvtVersion, SWIGTYPE_p_CigiCnvtInfoType__Type CnvtInfo) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_GetCnvt(swigCPtr, CigiVersionID.getCPtr(CnvtVersion), SWIGTYPE_p_CigiCnvtInfoType__Type.getCPtr(CnvtInfo));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetRequestID(SWIGTYPE_p_unsigned___int8 RequestIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetRequestID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(RequestIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetRequestID(SWIGTYPE_p_unsigned___int8 RequestIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetRequestID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(RequestIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int8 GetRequestID() {
    SWIGTYPE_p_unsigned___int8 ret = new SWIGTYPE_p_unsigned___int8(ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_GetRequestID(swigCPtr), true);
    return ret;
  }

  public int SetSurfaceHeight(float SurfaceHeightIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetSurfaceHeight__SWIG_0(swigCPtr, SurfaceHeightIn, bndchk);
    return ret;
  }

  public int SetSurfaceHeight(float SurfaceHeightIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetSurfaceHeight__SWIG_1(swigCPtr, SurfaceHeightIn);
    return ret;
  }

  public float GetSurfaceHeight() {
    float ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_GetSurfaceHeight(swigCPtr);
    return ret;
  }

  public int SetWaterTemp(float WaterTempIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetWaterTemp__SWIG_0(swigCPtr, WaterTempIn, bndchk);
    return ret;
  }

  public int SetWaterTemp(float WaterTempIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetWaterTemp__SWIG_1(swigCPtr, WaterTempIn);
    return ret;
  }

  public float GetWaterTemp() {
    float ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_GetWaterTemp(swigCPtr);
    return ret;
  }

  public int SetClarity(float ClarityIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetClarity__SWIG_0(swigCPtr, ClarityIn, bndchk);
    return ret;
  }

  public int SetClarity(float ClarityIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_SetClarity__SWIG_1(swigCPtr, ClarityIn);
    return ret;
  }

  public float GetClarity() {
    float ret = ccl_dllDPINVOKE.CigiBaseMaritimeSurfaceResp_GetClarity(swigCPtr);
    return ret;
  }

}
