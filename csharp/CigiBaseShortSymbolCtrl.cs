//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CigiBaseShortSymbolCtrl : CigiBasePacket {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CigiBaseShortSymbolCtrl(global::System.IntPtr cPtr, bool cMemoryOwn) : base(ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CigiBaseShortSymbolCtrl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CigiBaseShortSymbolCtrl obj) {
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
          ccl_dllDPINVOKE.delete_CigiBaseShortSymbolCtrl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public class DatumUnionType : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal DatumUnionType(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DatumUnionType obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef swigRelease(DatumUnionType obj) {
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
  
    ~DatumUnionType() {
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
            ccl_dllDPINVOKE.delete_CigiBaseShortSymbolCtrl_DatumUnionType(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public SWIGTYPE_p_unsigned___int32 UIntValue {
      set {
        ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_DatumUnionType_UIntValue_set(swigCPtr, SWIGTYPE_p_unsigned___int32.getCPtr(value));
        if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
      } 
      get {
        SWIGTYPE_p_unsigned___int32 ret = new SWIGTYPE_p_unsigned___int32(ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_DatumUnionType_UIntValue_get(swigCPtr), true);
        if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
        return ret;
      } 
    }
  
    public float FloatValue {
      set {
        ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_DatumUnionType_FloatValue_set(swigCPtr, value);
      } 
      get {
        float ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_DatumUnionType_FloatValue_get(swigCPtr);
        return ret;
      } 
    }
  
    public DatumUnionType() : this(ccl_dllDPINVOKE.new_DatumUnionType(), true) {
    }
  
  }

  public override int Pack(CigiBasePacket Base, SWIGTYPE_p_unsigned___int8 Buff, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_Pack(swigCPtr, CigiBasePacket.getCPtr(Base), SWIGTYPE_p_unsigned___int8.getCPtr(Buff), SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int Unpack(SWIGTYPE_p_unsigned___int8 Buff, bool Swap, SWIGTYPE_p_void Spec) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_Unpack(swigCPtr, SWIGTYPE_p_unsigned___int8.getCPtr(Buff), Swap, SWIGTYPE_p_void.getCPtr(Spec));
    return ret;
  }

  public override int GetCnvt(CigiVersionID CnvtVersion, SWIGTYPE_p_CigiCnvtInfoType__Type CnvtInfo) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetCnvt(swigCPtr, CigiVersionID.getCPtr(CnvtVersion), SWIGTYPE_p_CigiCnvtInfoType__Type.getCPtr(CnvtInfo));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetSymbolID(SWIGTYPE_p_unsigned___int16 SymbolIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSymbolID__SWIG_0(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(SymbolIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetSymbolID(SWIGTYPE_p_unsigned___int16 SymbolIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSymbolID__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned___int16.getCPtr(SymbolIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned___int16 GetSymbolID() {
    SWIGTYPE_p_unsigned___int16 ret = new SWIGTYPE_p_unsigned___int16(ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetSymbolID(swigCPtr), true);
    return ret;
  }

  public int SetSymbolState(CigiBaseSymbolCtrl.SymbolStateGrp SymbolStateIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSymbolState__SWIG_0(swigCPtr, (int)SymbolStateIn, bndchk);
    return ret;
  }

  public int SetSymbolState(CigiBaseSymbolCtrl.SymbolStateGrp SymbolStateIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSymbolState__SWIG_1(swigCPtr, (int)SymbolStateIn);
    return ret;
  }

  public CigiBaseSymbolCtrl.SymbolStateGrp GetSymbolState() {
    CigiBaseSymbolCtrl.SymbolStateGrp ret = (CigiBaseSymbolCtrl.SymbolStateGrp)ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetSymbolState(swigCPtr);
    return ret;
  }

  public int SetAttachState(CigiBaseSymbolCtrl.AttachStateGrp AttachStateIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetAttachState__SWIG_0(swigCPtr, (int)AttachStateIn, bndchk);
    return ret;
  }

  public int SetAttachState(CigiBaseSymbolCtrl.AttachStateGrp AttachStateIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetAttachState__SWIG_1(swigCPtr, (int)AttachStateIn);
    return ret;
  }

  public CigiBaseSymbolCtrl.AttachStateGrp GetAttachState() {
    CigiBaseSymbolCtrl.AttachStateGrp ret = (CigiBaseSymbolCtrl.AttachStateGrp)ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetAttachState(swigCPtr);
    return ret;
  }

  public int SetFlashCtrl(CigiBaseSymbolCtrl.FlashCtrlGrp FlashCtrlIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashCtrl__SWIG_0(swigCPtr, (int)FlashCtrlIn, bndchk);
    return ret;
  }

  public int SetFlashCtrl(CigiBaseSymbolCtrl.FlashCtrlGrp FlashCtrlIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashCtrl__SWIG_1(swigCPtr, (int)FlashCtrlIn);
    return ret;
  }

  public CigiBaseSymbolCtrl.FlashCtrlGrp GetFlashCtrl() {
    CigiBaseSymbolCtrl.FlashCtrlGrp ret = (CigiBaseSymbolCtrl.FlashCtrlGrp)ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetFlashCtrl(swigCPtr);
    return ret;
  }

  public int SetInheritColor(CigiBaseSymbolCtrl.InheritColorGrp InheritColorIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetInheritColor__SWIG_0(swigCPtr, (int)InheritColorIn, bndchk);
    return ret;
  }

  public int SetInheritColor(CigiBaseSymbolCtrl.InheritColorGrp InheritColorIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetInheritColor__SWIG_1(swigCPtr, (int)InheritColorIn);
    return ret;
  }

  public CigiBaseSymbolCtrl.InheritColorGrp GetInheritColor() {
    CigiBaseSymbolCtrl.InheritColorGrp ret = (CigiBaseSymbolCtrl.InheritColorGrp)ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetInheritColor(swigCPtr);
    return ret;
  }

  public CigiBaseShortSymbolCtrl.DatumTypeGrp GetDatumType(int DatumId) {
    CigiBaseShortSymbolCtrl.DatumTypeGrp ret = (CigiBaseShortSymbolCtrl.DatumTypeGrp)ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetDatumType(swigCPtr, DatumId);
    return ret;
  }

  public SWIGTYPE_p_unsigned___int32 GetUIntDatum(int DatumId) {
    SWIGTYPE_p_unsigned___int32 ret = new SWIGTYPE_p_unsigned___int32(ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetUIntDatum(swigCPtr, DatumId), true);
    return ret;
  }

  public int GetColorDatum(int DatumId, SWIGTYPE_p_unsigned___int8 RedValue, SWIGTYPE_p_unsigned___int8 GreenValue, SWIGTYPE_p_unsigned___int8 BlueValue, SWIGTYPE_p_unsigned___int8 AlphaValue, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetColorDatum__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(RedValue), SWIGTYPE_p_unsigned___int8.getCPtr(GreenValue), SWIGTYPE_p_unsigned___int8.getCPtr(BlueValue), SWIGTYPE_p_unsigned___int8.getCPtr(AlphaValue), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetColorDatum(int DatumId, SWIGTYPE_p_unsigned___int8 RedValue, SWIGTYPE_p_unsigned___int8 GreenValue, SWIGTYPE_p_unsigned___int8 BlueValue, SWIGTYPE_p_unsigned___int8 AlphaValue) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetColorDatum__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(RedValue), SWIGTYPE_p_unsigned___int8.getCPtr(GreenValue), SWIGTYPE_p_unsigned___int8.getCPtr(BlueValue), SWIGTYPE_p_unsigned___int8.getCPtr(AlphaValue));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetFloatDatum(int DatumId) {
    float ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_GetFloatDatum(swigCPtr, DatumId);
    return ret;
  }

  public int SetDatumNone(int DatumId, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetDatumNone__SWIG_0(swigCPtr, DatumId, bndchk);
    return ret;
  }

  public int SetDatumNone(int DatumId) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetDatumNone__SWIG_1(swigCPtr, DatumId);
    return ret;
  }

  public int SetSurfaceID(int DatumId, SWIGTYPE_p_unsigned___int16 SurfaceIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSurfaceID__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int16.getCPtr(SurfaceIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetSurfaceID(int DatumId, SWIGTYPE_p_unsigned___int16 SurfaceIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetSurfaceID__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int16.getCPtr(SurfaceIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetParentSymbolID(int DatumId, SWIGTYPE_p_unsigned___int16 ParentSymbolIDIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetParentSymbolID__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int16.getCPtr(ParentSymbolIDIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetParentSymbolID(int DatumId, SWIGTYPE_p_unsigned___int16 ParentSymbolIDIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetParentSymbolID__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int16.getCPtr(ParentSymbolIDIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetLayer(int DatumId, SWIGTYPE_p_unsigned___int8 LayerIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetLayer__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(LayerIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetLayer(int DatumId, SWIGTYPE_p_unsigned___int8 LayerIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetLayer__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(LayerIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFlashDutyCycle(int DatumId, SWIGTYPE_p_unsigned___int8 FlashDutyCycleIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashDutyCycle__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(FlashDutyCycleIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFlashDutyCycle(int DatumId, SWIGTYPE_p_unsigned___int8 FlashDutyCycleIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashDutyCycle__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(FlashDutyCycleIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetFlashPeriod(int DatumId, float FlashPeriodIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashPeriod__SWIG_0(swigCPtr, DatumId, FlashPeriodIn, bndchk);
    return ret;
  }

  public int SetFlashPeriod(int DatumId, float FlashPeriodIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetFlashPeriod__SWIG_1(swigCPtr, DatumId, FlashPeriodIn);
    return ret;
  }

  public int SetUPosition(int DatumId, float UPositionIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetUPosition__SWIG_0(swigCPtr, DatumId, UPositionIn, bndchk);
    return ret;
  }

  public int SetUPosition(int DatumId, float UPositionIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetUPosition__SWIG_1(swigCPtr, DatumId, UPositionIn);
    return ret;
  }

  public int SetVPosition(int DatumId, float VPositionIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetVPosition__SWIG_0(swigCPtr, DatumId, VPositionIn, bndchk);
    return ret;
  }

  public int SetVPosition(int DatumId, float VPositionIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetVPosition__SWIG_1(swigCPtr, DatumId, VPositionIn);
    return ret;
  }

  public int SetRotation(int DatumId, float RotationIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetRotation__SWIG_0(swigCPtr, DatumId, RotationIn, bndchk);
    return ret;
  }

  public int SetRotation(int DatumId, float RotationIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetRotation__SWIG_1(swigCPtr, DatumId, RotationIn);
    return ret;
  }

  public int SetScaleU(int DatumId, float ScaleUIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetScaleU__SWIG_0(swigCPtr, DatumId, ScaleUIn, bndchk);
    return ret;
  }

  public int SetScaleU(int DatumId, float ScaleUIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetScaleU__SWIG_1(swigCPtr, DatumId, ScaleUIn);
    return ret;
  }

  public int SetScaleV(int DatumId, float ScaleVIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetScaleV__SWIG_0(swigCPtr, DatumId, ScaleVIn, bndchk);
    return ret;
  }

  public int SetScaleV(int DatumId, float ScaleVIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetScaleV__SWIG_1(swigCPtr, DatumId, ScaleVIn);
    return ret;
  }

  public int SetColor(int DatumId, SWIGTYPE_p_unsigned___int8 RedIn, SWIGTYPE_p_unsigned___int8 GreenIn, SWIGTYPE_p_unsigned___int8 BlueIn, SWIGTYPE_p_unsigned___int8 AlphaIn, bool bndchk) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetColor__SWIG_0(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(RedIn), SWIGTYPE_p_unsigned___int8.getCPtr(GreenIn), SWIGTYPE_p_unsigned___int8.getCPtr(BlueIn), SWIGTYPE_p_unsigned___int8.getCPtr(AlphaIn), bndchk);
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int SetColor(int DatumId, SWIGTYPE_p_unsigned___int8 RedIn, SWIGTYPE_p_unsigned___int8 GreenIn, SWIGTYPE_p_unsigned___int8 BlueIn, SWIGTYPE_p_unsigned___int8 AlphaIn) {
    int ret = ccl_dllDPINVOKE.CigiBaseShortSymbolCtrl_SetColor__SWIG_1(swigCPtr, DatumId, SWIGTYPE_p_unsigned___int8.getCPtr(RedIn), SWIGTYPE_p_unsigned___int8.getCPtr(GreenIn), SWIGTYPE_p_unsigned___int8.getCPtr(BlueIn), SWIGTYPE_p_unsigned___int8.getCPtr(AlphaIn));
    if (ccl_dllDPINVOKE.SWIGPendingException.Pending) throw ccl_dllDPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum DatumTypeGrp {
    None = 0,
    SurfaceIdDatumType = 1,
    ParentIdDatumType = 2,
    LayerDatumType = 3,
    FlashDutyCycleDatumType = 4,
    FlashPeriodDatumType = 5,
    UPositionDatumType = 6,
    VPositionDatumType = 7,
    RotationDatumType = 8,
    ColorDatumType = 9,
    ScaleUDatumType = 10,
    ScaleVDatumType = 11
  }

}
