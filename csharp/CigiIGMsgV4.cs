//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiIGMsgV4 : CigiBaseIGMsg {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiIGMsgV4(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiIGMsgV4_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiIGMsgV4 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiIGMsgV4 obj) {
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
          ccl_dllDPINVOKE.delete_CigiIGMsgV4(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public CigiIGMsgV4() : this(ccl_dllDPINVOKE.new_CigiIGMsgV4(), true) {
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiIGMsgV4_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiIGMsgV4_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetTruePacketSize(CigiBaseVariableSizePckt refPacket) {
    int ret = ccl_dllDPINVOKE.CigiIGMsgV4_GetTruePacketSize(swigCPtr, CigiBaseVariableSizePckt.getCPtr(refPacket));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetMsg(string MsgIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiIGMsgV4_SetMsg__SWIG_0(swigCPtr, MsgIn, bndchk);
    return ret;
  }

  public int SetMsg(string MsgIn) {
    int ret = ccl_dllDPINVOKE.CigiIGMsgV4_SetMsg__SWIG_1(swigCPtr, MsgIn);
    return ret;
  }

  public static readonly int PacketHeaderSize = ccl_dllDPINVOKE.CigiIGMsgV4_PacketHeaderSize_get();
  public static readonly int MaxMessageSize = ccl_dllDPINVOKE.CigiIGMsgV4_MaxMessageSize_get();

}
