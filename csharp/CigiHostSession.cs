//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiHostSession : CigiSession {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiHostSession(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiHostSession_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiHostSession obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiHostSession obj) {
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
          ccl_dllDPINVOKE.delete_CigiHostSession(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiHostSession(int NumInBuf, int InBufLen, int NumOutBuf, int OutBufLen) : this(ccl_dllDPINVOKE.new_CigiHostSession__SWIG_0(NumInBuf, InBufLen, NumOutBuf, OutBufLen), true) {
  }

  public CigiHostSession(int NumInBuf, int InBufLen, int NumOutBuf) : this(ccl_dllDPINVOKE.new_CigiHostSession__SWIG_1(NumInBuf, InBufLen, NumOutBuf), true) {
  }

  public CigiHostSession(int NumInBuf, int InBufLen) : this(ccl_dllDPINVOKE.new_CigiHostSession__SWIG_2(NumInBuf, InBufLen), true) {
  }

  public CigiHostSession(int NumInBuf) : this(ccl_dllDPINVOKE.new_CigiHostSession__SWIG_3(NumInBuf), true) {
  }

  public CigiHostSession() : this(ccl_dllDPINVOKE.new_CigiHostSession__SWIG_4(), true) {
  }

}
