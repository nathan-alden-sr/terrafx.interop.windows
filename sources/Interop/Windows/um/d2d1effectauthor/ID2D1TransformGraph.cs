// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>The implementation of the actual graph.</summary>
    [Guid("13D29038-C3E6-4034-9081-13B53A417992")]
    public unsafe struct ID2D1TransformGraph
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1TransformGraph* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1TransformGraph* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1TransformGraph* This
        );
        #endregion

        #region Delegates
        /// <summary>Return the number of input this graph has.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetInputCount(
            [In] ID2D1TransformGraph* This
        );

        /// <summary>Sets the graph to contain a single transform whose inputs map 1:1 with effect inputs.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetSingleTransformNode(
            [In] ID2D1TransformGraph* This,
            [In] ID2D1TransformNode* node
        );

        /// <summary>Adds the given transform node to the graph.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _AddNode(
            [In] ID2D1TransformGraph* This,
            [In] ID2D1TransformNode* node
        );

        /// <summary>Removes the given transform node from the graph.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _RemoveNode(
            [In] ID2D1TransformGraph* This,
            [In] ID2D1TransformNode* node
        );

        /// <summary>Indicates that the given transform node should be considered to be the output node of the graph.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetOutputNode(
            [In] ID2D1TransformGraph* This,
            [In] ID2D1TransformNode* node
        );

        /// <summary>Connects one node to another node inside the graph.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ConnectNode(
            [In] ID2D1TransformGraph* This,
            [In] ID2D1TransformNode* fromNode,
            [In] ID2D1TransformNode* toNode,
            [In, NativeTypeName("UINT32")] uint toNodeInputIndex
        );

        /// <summary>Connects a transform node inside the graph to the corresponding input of the encapsulating effect.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _ConnectToEffectInput(
            [In] ID2D1TransformGraph* This,
            [In, NativeTypeName("UINT32")] uint toEffectInputIndex,
            [In] ID2D1TransformNode* node,
            [In, NativeTypeName("UINT32")] uint toNodeInputIndex
        );

        /// <summary>Clears all nodes and connections from the transform graph.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Clear(
            [In] ID2D1TransformGraph* This
        );

        /// <summary>Uses the specified input as the effect output.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SetPassthroughGraph(
            [In] ID2D1TransformGraph* This,
            [In, NativeTypeName("UINT32")] uint effectInputIndex
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_GetInputCount>(lpVtbl->GetInputCount)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSingleTransformNode(
            [In] ID2D1TransformNode* node
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_SetSingleTransformNode>(lpVtbl->SetSingleTransformNode)(
                    This,
                    node
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AddNode(
            [In] ID2D1TransformNode* node
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_AddNode>(lpVtbl->AddNode)(
                    This,
                    node
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int RemoveNode(
            [In] ID2D1TransformNode* node
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_RemoveNode>(lpVtbl->RemoveNode)(
                    This,
                    node
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOutputNode(
            [In] ID2D1TransformNode* node
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_SetOutputNode>(lpVtbl->SetOutputNode)(
                    This,
                    node
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectNode(
            [In] ID2D1TransformNode* fromNode,
            [In] ID2D1TransformNode* toNode,
            [In, NativeTypeName("UINT32")] uint toNodeInputIndex
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_ConnectNode>(lpVtbl->ConnectNode)(
                    This,
                    fromNode,
                    toNode,
                    toNodeInputIndex
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectToEffectInput(
            [In, NativeTypeName("UINT32")] uint toEffectInputIndex,
            [In] ID2D1TransformNode* node,
            [In, NativeTypeName("UINT32")] uint toNodeInputIndex
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_ConnectToEffectInput>(lpVtbl->ConnectToEffectInput)(
                    This,
                    toEffectInputIndex,
                    node,
                    toNodeInputIndex
                );
            }
        }

        public void Clear()
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                MarshalFunction<_Clear>(lpVtbl->Clear)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPassthroughGraph(
            [In, NativeTypeName("UINT32")] uint effectInputIndex
        )
        {
            fixed (ID2D1TransformGraph* This = &this)
            {
                return MarshalFunction<_SetPassthroughGraph>(lpVtbl->SetPassthroughGraph)(
                    This,
                    effectInputIndex
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr GetInputCount;

            public IntPtr SetSingleTransformNode;

            public IntPtr AddNode;

            public IntPtr RemoveNode;

            public IntPtr SetOutputNode;

            public IntPtr ConnectNode;

            public IntPtr ConnectToEffectInput;

            public IntPtr Clear;

            public IntPtr SetPassthroughGraph;
            #endregion
        }
        #endregion
    }
}
