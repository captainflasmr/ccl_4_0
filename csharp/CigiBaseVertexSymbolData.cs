//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiBaseVertexSymbolData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CigiBaseVertexSymbolData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiBaseVertexSymbolData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiBaseVertexSymbolData obj) {
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

  ~CigiBaseVertexSymbolData() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ccl_dllDPINVOKE.delete_CigiBaseVertexSymbolData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual int Pack(CigiBaseVertexSymbolData Base, SWIGTYPE_p_unsigned___int8 Buff) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_Pack(swigCPtr, CigiBaseVertexSymbolData.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff));
    return ret;
  }

  public virtual int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap);
    return ret;
  }

  public int SetVertex(float VertexUIn, float VertexVIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertex__SWIG_0(swigCPtr, VertexUIn, VertexVIn, bndchk);
    return ret;
  }

  public int SetVertex(float VertexUIn, float VertexVIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertex__SWIG_1(swigCPtr, VertexUIn, VertexVIn);
    return ret;
  }

  public int GetVertex(SWIGTYPE_p_float VertexUIn, SWIGTYPE_p_float VertexVIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_GetVertex(swigCPtr, SWIGTYPE_p_float.getCPtr(VertexUIn), SWIGTYPE_p_float.getCPtr(VertexVIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetVertexU(float VertexUIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertexU__SWIG_0(swigCPtr, VertexUIn, bndchk);
    return ret;
  }

  public int SetVertexU(float VertexUIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertexU__SWIG_1(swigCPtr, VertexUIn);
    return ret;
  }

  public float GetVertexU() {
    float ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_GetVertexU(swigCPtr);
    return ret;
  }

  public int SetVertexV(float VertexVIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertexV__SWIG_0(swigCPtr, VertexVIn, bndchk);
    return ret;
  }

  public int SetVertexV(float VertexVIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_SetVertexV__SWIG_1(swigCPtr, VertexVIn);
    return ret;
  }

  public float GetVertexV() {
    float ret = ccl_dllDPINVOKE.CigiBaseVertexSymbolData_GetVertexV(swigCPtr);
    return ret;
  }

}
