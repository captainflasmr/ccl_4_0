//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiTrajectoryDefV3 : CigiBaseTrajectoryDef {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiTrajectoryDefV3(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiTrajectoryDefV3_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiTrajectoryDefV3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiTrajectoryDefV3 obj) {
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
          ccl_dllDPINVOKE.delete_CigiTrajectoryDefV3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiTrajectoryDefV3() : this(ccl_dllDPINVOKE.new_CigiTrajectoryDefV3(), true) {
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public int SetAccelX(float AccelIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelX__SWIG_0(swigCPtr, AccelIn, bndchk);
    return ret;
  }

  public int SetAccelX(float AccelIn) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelX__SWIG_1(swigCPtr, AccelIn);
    return ret;
  }

  public float GetAccelX() {
    float ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_GetAccelX(swigCPtr);
    return ret;
  }

  public int SetAccelY(float AccelIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelY__SWIG_0(swigCPtr, AccelIn, bndchk);
    return ret;
  }

  public int SetAccelY(float AccelIn) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelY__SWIG_1(swigCPtr, AccelIn);
    return ret;
  }

  public float GetAccelY() {
    float ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_GetAccelY(swigCPtr);
    return ret;
  }

  public int SetAccelZ(float AccelIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelZ__SWIG_0(swigCPtr, AccelIn, bndchk);
    return ret;
  }

  public int SetAccelZ(float AccelIn) {
    int ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_SetAccelZ__SWIG_1(swigCPtr, AccelIn);
    return ret;
  }

  public float GetAccelZ() {
    float ret = ccl_dllDPINVOKE.CigiTrajectoryDefV3_GetAccelZ(swigCPtr);
    return ret;
  }

}
