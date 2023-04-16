﻿#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[6] = 
{
	{ 15778, 0,  0 } /*tableIndex: 0 */,
	{ 15778, 0,  2 } /*tableIndex: 1 */,
	{ 15781, 1,  4 } /*tableIndex: 2 */,
	{ 15785, 2,  6 } /*tableIndex: 3 */,
	{ 15778, 3,  10 } /*tableIndex: 4 */,
	{ 15783, 4,  12 } /*tableIndex: 5 */,
};
#else
static const Il2CppMethodExecutionContextInfo g_methodExecutionContextInfos[1] = { { 0, 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const char* g_methodExecutionContextInfoStrings[5] = 
{
	"eventAttribute",
	"expressionValue",
	"spawnerState",
	"vfxEventAttribute",
	"evt",
};
#else
static const char* g_methodExecutionContextInfoStrings[1] = { NULL };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[33] = 
{
	{ 0, 0 } /* 0x06000001 System.Void UnityEngine.VFX.VFXEventAttribute::.ctor(System.IntPtr,System.Boolean,UnityEngine.VFX.VisualEffectAsset) */,
	{ 0, 1 } /* 0x06000002 UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VFXEventAttribute::CreateEventAttributeWrapper() */,
	{ 0, 0 } /* 0x06000003 System.Void UnityEngine.VFX.VFXEventAttribute::SetWrapValue(System.IntPtr) */,
	{ 0, 0 } /* 0x06000004 System.IntPtr UnityEngine.VFX.VFXEventAttribute::Internal_Create() */,
	{ 1, 1 } /* 0x06000005 UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VFXEventAttribute::Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset) */,
	{ 0, 0 } /* 0x06000006 System.Void UnityEngine.VFX.VFXEventAttribute::Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset) */,
	{ 0, 0 } /* 0x06000007 System.Void UnityEngine.VFX.VFXEventAttribute::Release() */,
	{ 0, 0 } /* 0x06000008 System.Void UnityEngine.VFX.VFXEventAttribute::Finalize() */,
	{ 0, 0 } /* 0x06000009 System.Void UnityEngine.VFX.VFXEventAttribute::Dispose() */,
	{ 0, 0 } /* 0x0600000A System.Void UnityEngine.VFX.VFXEventAttribute::Internal_Destroy(System.IntPtr) */,
	{ 0, 0 } /* 0x0600000B System.Void UnityEngine.VFX.VFXExpressionValues::.ctor() */,
	{ 2, 1 } /* 0x0600000C UnityEngine.VFX.VFXExpressionValues UnityEngine.VFX.VFXExpressionValues::CreateExpressionValuesWrapper(System.IntPtr) */,
	{ 0, 0 } /* 0x0600000D System.Void UnityEngine.VFX.VFXManager::.cctor() */,
	{ 0, 0 } /* 0x0600000E System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnPlay(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0 } /* 0x0600000F System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnUpdate(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0 } /* 0x06000010 System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnStop(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0 } /* 0x06000011 System.Void UnityEngine.VFX.VFXSpawnerCallbacks::.ctor() */,
	{ 0, 0 } /* 0x06000012 System.Void UnityEngine.VFX.VFXSpawnerState::.ctor(System.IntPtr,System.Boolean) */,
	{ 3, 1 } /* 0x06000013 UnityEngine.VFX.VFXSpawnerState UnityEngine.VFX.VFXSpawnerState::CreateSpawnerStateWrapper() */,
	{ 0, 0 } /* 0x06000014 System.Void UnityEngine.VFX.VFXSpawnerState::PrepareWrapper() */,
	{ 0, 0 } /* 0x06000015 System.Void UnityEngine.VFX.VFXSpawnerState::SetWrapValue(System.IntPtr,System.IntPtr) */,
	{ 0, 0 } /* 0x06000016 System.Void UnityEngine.VFX.VFXSpawnerState::Release() */,
	{ 0, 0 } /* 0x06000017 System.Void UnityEngine.VFX.VFXSpawnerState::Finalize() */,
	{ 0, 0 } /* 0x06000018 System.Void UnityEngine.VFX.VFXSpawnerState::Dispose() */,
	{ 0, 0 } /* 0x06000019 System.Void UnityEngine.VFX.VFXSpawnerState::Internal_Destroy(System.IntPtr) */,
	{ 0, 0 } /* 0x0600001A System.Void UnityEngine.VFX.VisualEffectObject::.ctor() */,
	{ 0, 0 } /* 0x0600001B System.Void UnityEngine.VFX.VisualEffectAsset::.ctor() */,
	{ 0, 0 } /* 0x0600001C System.Void UnityEngine.VFX.VisualEffectAsset::.cctor() */,
	{ 0, 0 } /* 0x0600001D System.Void UnityEngine.VFX.VFXOutputEventArgs::.ctor(System.Int32,UnityEngine.VFX.VFXEventAttribute) */,
	{ 0, 0 } /* 0x0600001E UnityEngine.VFX.VisualEffectAsset UnityEngine.VFX.VisualEffect::get_visualEffectAsset() */,
	{ 4, 1 } /* 0x0600001F UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VisualEffect::CreateVFXEventAttribute() */,
	{ 0, 0 } /* 0x06000020 UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VisualEffect::InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect) */,
	{ 5, 1 } /* 0x06000021 System.Void UnityEngine.VFX.VisualEffect::InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect,System.Int32) */,
};
#else
static const Il2CppMethodExecutionContextInfoIndex g_methodExecutionContextInfoIndexes[1] = { { 0, 0} };
#endif
#if IL2CPP_MONO_DEBUGGER
IL2CPP_EXTERN_C Il2CppSequencePoint g_sequencePointsUnityEngine_VFXModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_VFXModule[203] = 
{
	{ 54875, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 0 } /* seqPointIndex: 0 */,
	{ 54875, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 1 } /* seqPointIndex: 1 */,
	{ 54875, 1, 16, 16, 9, 86, 0, kSequencePointKind_Normal, 0, 2 } /* seqPointIndex: 2 */,
	{ 54875, 1, 16, 16, 9, 86, 1, kSequencePointKind_StepOut, 0, 3 } /* seqPointIndex: 3 */,
	{ 54875, 1, 17, 17, 9, 10, 7, kSequencePointKind_Normal, 0, 4 } /* seqPointIndex: 4 */,
	{ 54875, 1, 18, 18, 13, 25, 8, kSequencePointKind_Normal, 0, 5 } /* seqPointIndex: 5 */,
	{ 54875, 1, 19, 19, 13, 29, 15, kSequencePointKind_Normal, 0, 6 } /* seqPointIndex: 6 */,
	{ 54875, 1, 20, 20, 13, 35, 22, kSequencePointKind_Normal, 0, 7 } /* seqPointIndex: 7 */,
	{ 54875, 1, 21, 21, 9, 10, 29, kSequencePointKind_Normal, 0, 8 } /* seqPointIndex: 8 */,
	{ 54876, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 9 } /* seqPointIndex: 9 */,
	{ 54876, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 10 } /* seqPointIndex: 10 */,
	{ 54876, 1, 28, 28, 9, 10, 0, kSequencePointKind_Normal, 0, 11 } /* seqPointIndex: 11 */,
	{ 54876, 1, 29, 29, 13, 82, 1, kSequencePointKind_Normal, 0, 12 } /* seqPointIndex: 12 */,
	{ 54876, 1, 29, 29, 13, 82, 8, kSequencePointKind_StepOut, 0, 13 } /* seqPointIndex: 13 */,
	{ 54876, 1, 30, 30, 13, 35, 14, kSequencePointKind_Normal, 0, 14 } /* seqPointIndex: 14 */,
	{ 54876, 1, 31, 31, 9, 10, 18, kSequencePointKind_Normal, 0, 15 } /* seqPointIndex: 15 */,
	{ 54877, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 16 } /* seqPointIndex: 16 */,
	{ 54877, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 17 } /* seqPointIndex: 17 */,
	{ 54877, 1, 34, 34, 9, 10, 0, kSequencePointKind_Normal, 0, 18 } /* seqPointIndex: 18 */,
	{ 54877, 1, 35, 35, 13, 25, 1, kSequencePointKind_Normal, 0, 19 } /* seqPointIndex: 19 */,
	{ 54877, 1, 35, 35, 0, 0, 8, kSequencePointKind_Normal, 0, 20 } /* seqPointIndex: 20 */,
	{ 54877, 1, 36, 36, 17, 107, 11, kSequencePointKind_Normal, 0, 21 } /* seqPointIndex: 21 */,
	{ 54877, 1, 36, 36, 17, 107, 16, kSequencePointKind_StepOut, 0, 22 } /* seqPointIndex: 22 */,
	{ 54877, 1, 37, 37, 13, 41, 22, kSequencePointKind_Normal, 0, 23 } /* seqPointIndex: 23 */,
	{ 54877, 1, 39, 39, 9, 10, 29, kSequencePointKind_Normal, 0, 24 } /* seqPointIndex: 24 */,
	{ 54879, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 25 } /* seqPointIndex: 25 */,
	{ 54879, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 26 } /* seqPointIndex: 26 */,
	{ 54879, 1, 53, 53, 9, 10, 0, kSequencePointKind_Normal, 0, 27 } /* seqPointIndex: 27 */,
	{ 54879, 1, 54, 54, 13, 91, 1, kSequencePointKind_Normal, 0, 28 } /* seqPointIndex: 28 */,
	{ 54879, 1, 54, 54, 13, 91, 1, kSequencePointKind_StepOut, 0, 29 } /* seqPointIndex: 29 */,
	{ 54879, 1, 54, 54, 13, 91, 8, kSequencePointKind_StepOut, 0, 30 } /* seqPointIndex: 30 */,
	{ 54879, 1, 55, 55, 13, 61, 14, kSequencePointKind_Normal, 0, 31 } /* seqPointIndex: 31 */,
	{ 54879, 1, 55, 55, 13, 61, 16, kSequencePointKind_StepOut, 0, 32 } /* seqPointIndex: 32 */,
	{ 54879, 1, 56, 56, 13, 35, 22, kSequencePointKind_Normal, 0, 33 } /* seqPointIndex: 33 */,
	{ 54879, 1, 57, 57, 9, 10, 26, kSequencePointKind_Normal, 0, 34 } /* seqPointIndex: 34 */,
	{ 54881, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 35 } /* seqPointIndex: 35 */,
	{ 54881, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 36 } /* seqPointIndex: 36 */,
	{ 54881, 1, 65, 65, 9, 10, 0, kSequencePointKind_Normal, 0, 37 } /* seqPointIndex: 37 */,
	{ 54881, 1, 66, 66, 13, 49, 1, kSequencePointKind_Normal, 0, 38 } /* seqPointIndex: 38 */,
	{ 54881, 1, 66, 66, 13, 49, 20, kSequencePointKind_StepOut, 0, 39 } /* seqPointIndex: 39 */,
	{ 54881, 1, 66, 66, 0, 0, 29, kSequencePointKind_Normal, 0, 40 } /* seqPointIndex: 40 */,
	{ 54881, 1, 67, 67, 13, 14, 32, kSequencePointKind_Normal, 0, 41 } /* seqPointIndex: 41 */,
	{ 54881, 1, 68, 68, 17, 41, 33, kSequencePointKind_Normal, 0, 42 } /* seqPointIndex: 42 */,
	{ 54881, 1, 68, 68, 17, 41, 39, kSequencePointKind_StepOut, 0, 43 } /* seqPointIndex: 43 */,
	{ 54881, 1, 69, 69, 13, 14, 45, kSequencePointKind_Normal, 0, 44 } /* seqPointIndex: 44 */,
	{ 54881, 1, 70, 70, 13, 33, 46, kSequencePointKind_Normal, 0, 45 } /* seqPointIndex: 45 */,
	{ 54881, 1, 71, 71, 13, 31, 57, kSequencePointKind_Normal, 0, 46 } /* seqPointIndex: 46 */,
	{ 54881, 1, 72, 72, 9, 10, 64, kSequencePointKind_Normal, 0, 47 } /* seqPointIndex: 47 */,
	{ 54882, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 48 } /* seqPointIndex: 48 */,
	{ 54882, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 49 } /* seqPointIndex: 49 */,
	{ 54882, 1, 75, 75, 9, 10, 0, kSequencePointKind_Normal, 0, 50 } /* seqPointIndex: 50 */,
	{ 54882, 1, 75, 75, 9, 10, 1, kSequencePointKind_Normal, 0, 51 } /* seqPointIndex: 51 */,
	{ 54882, 1, 76, 76, 13, 23, 2, kSequencePointKind_Normal, 0, 52 } /* seqPointIndex: 52 */,
	{ 54882, 1, 76, 76, 13, 23, 3, kSequencePointKind_StepOut, 0, 53 } /* seqPointIndex: 53 */,
	{ 54882, 1, 77, 77, 9, 10, 11, kSequencePointKind_Normal, 0, 54 } /* seqPointIndex: 54 */,
	{ 54882, 1, 77, 77, 9, 10, 12, kSequencePointKind_StepOut, 0, 55 } /* seqPointIndex: 55 */,
	{ 54882, 1, 77, 77, 9, 10, 19, kSequencePointKind_Normal, 0, 56 } /* seqPointIndex: 56 */,
	{ 54883, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 57 } /* seqPointIndex: 57 */,
	{ 54883, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 58 } /* seqPointIndex: 58 */,
	{ 54883, 1, 80, 80, 9, 10, 0, kSequencePointKind_Normal, 0, 59 } /* seqPointIndex: 59 */,
	{ 54883, 1, 81, 81, 13, 23, 1, kSequencePointKind_Normal, 0, 60 } /* seqPointIndex: 60 */,
	{ 54883, 1, 81, 81, 13, 23, 2, kSequencePointKind_StepOut, 0, 61 } /* seqPointIndex: 61 */,
	{ 54883, 1, 82, 82, 13, 39, 8, kSequencePointKind_Normal, 0, 62 } /* seqPointIndex: 62 */,
	{ 54883, 1, 82, 82, 13, 39, 9, kSequencePointKind_StepOut, 0, 63 } /* seqPointIndex: 63 */,
	{ 54883, 1, 83, 83, 9, 10, 15, kSequencePointKind_Normal, 0, 64 } /* seqPointIndex: 64 */,
	{ 54885, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 65 } /* seqPointIndex: 65 */,
	{ 54885, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 66 } /* seqPointIndex: 66 */,
	{ 54885, 2, 14, 14, 9, 38, 0, kSequencePointKind_Normal, 0, 67 } /* seqPointIndex: 67 */,
	{ 54885, 2, 14, 14, 9, 38, 1, kSequencePointKind_StepOut, 0, 68 } /* seqPointIndex: 68 */,
	{ 54885, 2, 15, 15, 9, 10, 7, kSequencePointKind_Normal, 0, 69 } /* seqPointIndex: 69 */,
	{ 54885, 2, 16, 16, 9, 10, 8, kSequencePointKind_Normal, 0, 70 } /* seqPointIndex: 70 */,
	{ 54886, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 71 } /* seqPointIndex: 71 */,
	{ 54886, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 72 } /* seqPointIndex: 72 */,
	{ 54886, 2, 20, 20, 9, 10, 0, kSequencePointKind_Normal, 0, 73 } /* seqPointIndex: 73 */,
	{ 54886, 2, 21, 21, 13, 61, 1, kSequencePointKind_Normal, 0, 74 } /* seqPointIndex: 74 */,
	{ 54886, 2, 21, 21, 13, 61, 1, kSequencePointKind_StepOut, 0, 75 } /* seqPointIndex: 75 */,
	{ 54886, 2, 22, 22, 13, 41, 7, kSequencePointKind_Normal, 0, 76 } /* seqPointIndex: 76 */,
	{ 54886, 2, 23, 23, 13, 36, 14, kSequencePointKind_Normal, 0, 77 } /* seqPointIndex: 77 */,
	{ 54886, 2, 24, 24, 9, 10, 18, kSequencePointKind_Normal, 0, 78 } /* seqPointIndex: 78 */,
	{ 54887, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 79 } /* seqPointIndex: 79 */,
	{ 54887, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 80 } /* seqPointIndex: 80 */,
	{ 54887, 3, 43, 43, 9, 153, 0, kSequencePointKind_Normal, 0, 81 } /* seqPointIndex: 81 */,
	{ 54892, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 82 } /* seqPointIndex: 82 */,
	{ 54892, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 83 } /* seqPointIndex: 83 */,
	{ 54892, 4, 29, 29, 9, 57, 0, kSequencePointKind_Normal, 0, 84 } /* seqPointIndex: 84 */,
	{ 54892, 4, 29, 29, 9, 57, 1, kSequencePointKind_StepOut, 0, 85 } /* seqPointIndex: 85 */,
	{ 54892, 4, 30, 30, 9, 10, 7, kSequencePointKind_Normal, 0, 86 } /* seqPointIndex: 86 */,
	{ 54892, 4, 31, 31, 13, 25, 8, kSequencePointKind_Normal, 0, 87 } /* seqPointIndex: 87 */,
	{ 54892, 4, 32, 32, 13, 29, 15, kSequencePointKind_Normal, 0, 88 } /* seqPointIndex: 88 */,
	{ 54892, 4, 33, 33, 9, 10, 22, kSequencePointKind_Normal, 0, 89 } /* seqPointIndex: 89 */,
	{ 54893, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 90 } /* seqPointIndex: 90 */,
	{ 54893, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 91 } /* seqPointIndex: 91 */,
	{ 54893, 4, 39, 39, 9, 10, 0, kSequencePointKind_Normal, 0, 92 } /* seqPointIndex: 92 */,
	{ 54893, 4, 40, 40, 13, 72, 1, kSequencePointKind_Normal, 0, 93 } /* seqPointIndex: 93 */,
	{ 54893, 4, 40, 40, 13, 72, 7, kSequencePointKind_StepOut, 0, 94 } /* seqPointIndex: 94 */,
	{ 54893, 4, 41, 41, 13, 43, 13, kSequencePointKind_Normal, 0, 95 } /* seqPointIndex: 95 */,
	{ 54893, 4, 41, 41, 13, 43, 14, kSequencePointKind_StepOut, 0, 96 } /* seqPointIndex: 96 */,
	{ 54893, 4, 42, 42, 13, 33, 20, kSequencePointKind_Normal, 0, 97 } /* seqPointIndex: 97 */,
	{ 54893, 4, 43, 43, 9, 10, 24, kSequencePointKind_Normal, 0, 98 } /* seqPointIndex: 98 */,
	{ 54894, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 99 } /* seqPointIndex: 99 */,
	{ 54894, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 100 } /* seqPointIndex: 100 */,
	{ 54894, 4, 46, 46, 9, 10, 0, kSequencePointKind_Normal, 0, 101 } /* seqPointIndex: 101 */,
	{ 54894, 4, 47, 47, 13, 25, 1, kSequencePointKind_Normal, 0, 102 } /* seqPointIndex: 102 */,
	{ 54894, 4, 47, 47, 0, 0, 8, kSequencePointKind_Normal, 0, 103 } /* seqPointIndex: 103 */,
	{ 54894, 4, 48, 48, 17, 107, 11, kSequencePointKind_Normal, 0, 104 } /* seqPointIndex: 104 */,
	{ 54894, 4, 48, 48, 17, 107, 16, kSequencePointKind_StepOut, 0, 105 } /* seqPointIndex: 105 */,
	{ 54894, 4, 50, 50, 13, 46, 22, kSequencePointKind_Normal, 0, 106 } /* seqPointIndex: 106 */,
	{ 54894, 4, 50, 50, 0, 0, 32, kSequencePointKind_Normal, 0, 107 } /* seqPointIndex: 107 */,
	{ 54894, 4, 51, 51, 17, 99, 35, kSequencePointKind_Normal, 0, 108 } /* seqPointIndex: 108 */,
	{ 54894, 4, 51, 51, 17, 99, 40, kSequencePointKind_StepOut, 0, 109 } /* seqPointIndex: 109 */,
	{ 54894, 4, 53, 53, 13, 84, 46, kSequencePointKind_Normal, 0, 110 } /* seqPointIndex: 110 */,
	{ 54894, 4, 53, 53, 13, 84, 47, kSequencePointKind_StepOut, 0, 111 } /* seqPointIndex: 111 */,
	{ 54894, 4, 54, 54, 9, 10, 57, kSequencePointKind_Normal, 0, 112 } /* seqPointIndex: 112 */,
	{ 54895, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 113 } /* seqPointIndex: 113 */,
	{ 54895, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 114 } /* seqPointIndex: 114 */,
	{ 54895, 4, 58, 58, 9, 10, 0, kSequencePointKind_Normal, 0, 115 } /* seqPointIndex: 115 */,
	{ 54895, 4, 59, 59, 13, 25, 1, kSequencePointKind_Normal, 0, 116 } /* seqPointIndex: 116 */,
	{ 54895, 4, 59, 59, 0, 0, 8, kSequencePointKind_Normal, 0, 117 } /* seqPointIndex: 117 */,
	{ 54895, 4, 60, 60, 17, 107, 11, kSequencePointKind_Normal, 0, 118 } /* seqPointIndex: 118 */,
	{ 54895, 4, 60, 60, 17, 107, 16, kSequencePointKind_StepOut, 0, 119 } /* seqPointIndex: 119 */,
	{ 54895, 4, 62, 62, 13, 46, 22, kSequencePointKind_Normal, 0, 120 } /* seqPointIndex: 120 */,
	{ 54895, 4, 62, 62, 0, 0, 32, kSequencePointKind_Normal, 0, 121 } /* seqPointIndex: 121 */,
	{ 54895, 4, 63, 63, 17, 81, 35, kSequencePointKind_Normal, 0, 122 } /* seqPointIndex: 122 */,
	{ 54895, 4, 63, 63, 17, 81, 40, kSequencePointKind_StepOut, 0, 123 } /* seqPointIndex: 123 */,
	{ 54895, 4, 65, 65, 13, 39, 46, kSequencePointKind_Normal, 0, 124 } /* seqPointIndex: 124 */,
	{ 54895, 4, 66, 66, 13, 68, 53, kSequencePointKind_Normal, 0, 125 } /* seqPointIndex: 125 */,
	{ 54895, 4, 66, 66, 13, 68, 60, kSequencePointKind_StepOut, 0, 126 } /* seqPointIndex: 126 */,
	{ 54895, 4, 67, 67, 9, 10, 66, kSequencePointKind_Normal, 0, 127 } /* seqPointIndex: 127 */,
	{ 54896, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 128 } /* seqPointIndex: 128 */,
	{ 54896, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 129 } /* seqPointIndex: 129 */,
	{ 54896, 4, 75, 75, 9, 10, 0, kSequencePointKind_Normal, 0, 130 } /* seqPointIndex: 130 */,
	{ 54896, 4, 76, 76, 13, 49, 1, kSequencePointKind_Normal, 0, 131 } /* seqPointIndex: 131 */,
	{ 54896, 4, 76, 76, 13, 49, 12, kSequencePointKind_StepOut, 0, 132 } /* seqPointIndex: 132 */,
	{ 54896, 4, 76, 76, 0, 0, 29, kSequencePointKind_Normal, 0, 133 } /* seqPointIndex: 133 */,
	{ 54896, 4, 77, 77, 13, 14, 32, kSequencePointKind_Normal, 0, 134 } /* seqPointIndex: 134 */,
	{ 54896, 4, 78, 78, 17, 41, 33, kSequencePointKind_Normal, 0, 135 } /* seqPointIndex: 135 */,
	{ 54896, 4, 78, 78, 17, 41, 39, kSequencePointKind_StepOut, 0, 136 } /* seqPointIndex: 136 */,
	{ 54896, 4, 79, 79, 13, 14, 45, kSequencePointKind_Normal, 0, 137 } /* seqPointIndex: 137 */,
	{ 54896, 4, 80, 80, 13, 33, 46, kSequencePointKind_Normal, 0, 138 } /* seqPointIndex: 138 */,
	{ 54896, 4, 81, 81, 13, 41, 57, kSequencePointKind_Normal, 0, 139 } /* seqPointIndex: 139 */,
	{ 54896, 4, 82, 82, 9, 10, 64, kSequencePointKind_Normal, 0, 140 } /* seqPointIndex: 140 */,
	{ 54897, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 141 } /* seqPointIndex: 141 */,
	{ 54897, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 142 } /* seqPointIndex: 142 */,
	{ 54897, 4, 85, 85, 9, 10, 0, kSequencePointKind_Normal, 0, 143 } /* seqPointIndex: 143 */,
	{ 54897, 4, 85, 85, 9, 10, 1, kSequencePointKind_Normal, 0, 144 } /* seqPointIndex: 144 */,
	{ 54897, 4, 86, 86, 13, 23, 2, kSequencePointKind_Normal, 0, 145 } /* seqPointIndex: 145 */,
	{ 54897, 4, 86, 86, 13, 23, 3, kSequencePointKind_StepOut, 0, 146 } /* seqPointIndex: 146 */,
	{ 54897, 4, 87, 87, 9, 10, 11, kSequencePointKind_Normal, 0, 147 } /* seqPointIndex: 147 */,
	{ 54897, 4, 87, 87, 9, 10, 12, kSequencePointKind_StepOut, 0, 148 } /* seqPointIndex: 148 */,
	{ 54897, 4, 87, 87, 9, 10, 19, kSequencePointKind_Normal, 0, 149 } /* seqPointIndex: 149 */,
	{ 54898, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 150 } /* seqPointIndex: 150 */,
	{ 54898, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 151 } /* seqPointIndex: 151 */,
	{ 54898, 4, 90, 90, 9, 10, 0, kSequencePointKind_Normal, 0, 152 } /* seqPointIndex: 152 */,
	{ 54898, 4, 91, 91, 13, 23, 1, kSequencePointKind_Normal, 0, 153 } /* seqPointIndex: 153 */,
	{ 54898, 4, 91, 91, 13, 23, 2, kSequencePointKind_StepOut, 0, 154 } /* seqPointIndex: 154 */,
	{ 54898, 4, 92, 92, 13, 39, 8, kSequencePointKind_Normal, 0, 155 } /* seqPointIndex: 155 */,
	{ 54898, 4, 92, 92, 13, 39, 9, kSequencePointKind_StepOut, 0, 156 } /* seqPointIndex: 156 */,
	{ 54898, 4, 93, 93, 9, 10, 15, kSequencePointKind_Normal, 0, 157 } /* seqPointIndex: 157 */,
	{ 54902, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 158 } /* seqPointIndex: 158 */,
	{ 54902, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 159 } /* seqPointIndex: 159 */,
	{ 54902, 5, 36, 36, 9, 85, 0, kSequencePointKind_Normal, 0, 160 } /* seqPointIndex: 160 */,
	{ 54902, 5, 36, 36, 9, 85, 5, kSequencePointKind_StepOut, 0, 161 } /* seqPointIndex: 161 */,
	{ 54902, 5, 37, 37, 9, 85, 15, kSequencePointKind_Normal, 0, 162 } /* seqPointIndex: 162 */,
	{ 54902, 5, 37, 37, 9, 85, 20, kSequencePointKind_StepOut, 0, 163 } /* seqPointIndex: 163 */,
	{ 54903, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 164 } /* seqPointIndex: 164 */,
	{ 54903, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 165 } /* seqPointIndex: 165 */,
	{ 54903, 5, 59, 59, 9, 10, 0, kSequencePointKind_Normal, 0, 166 } /* seqPointIndex: 166 */,
	{ 54903, 5, 60, 60, 13, 34, 1, kSequencePointKind_Normal, 0, 167 } /* seqPointIndex: 167 */,
	{ 54903, 5, 61, 61, 13, 50, 8, kSequencePointKind_Normal, 0, 168 } /* seqPointIndex: 168 */,
	{ 54903, 5, 62, 62, 9, 10, 15, kSequencePointKind_Normal, 0, 169 } /* seqPointIndex: 169 */,
	{ 54905, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 170 } /* seqPointIndex: 170 */,
	{ 54905, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 171 } /* seqPointIndex: 171 */,
	{ 54905, 5, 95, 95, 9, 10, 0, kSequencePointKind_Normal, 0, 172 } /* seqPointIndex: 172 */,
	{ 54905, 5, 96, 96, 13, 43, 1, kSequencePointKind_Normal, 0, 173 } /* seqPointIndex: 173 */,
	{ 54905, 5, 96, 96, 13, 43, 2, kSequencePointKind_StepOut, 0, 174 } /* seqPointIndex: 174 */,
	{ 54905, 5, 96, 96, 13, 43, 8, kSequencePointKind_StepOut, 0, 175 } /* seqPointIndex: 175 */,
	{ 54905, 5, 96, 96, 0, 0, 14, kSequencePointKind_Normal, 0, 176 } /* seqPointIndex: 176 */,
	{ 54905, 5, 97, 97, 17, 29, 17, kSequencePointKind_Normal, 0, 177 } /* seqPointIndex: 177 */,
	{ 54905, 5, 98, 98, 13, 112, 21, kSequencePointKind_Normal, 0, 178 } /* seqPointIndex: 178 */,
	{ 54905, 5, 98, 98, 13, 112, 22, kSequencePointKind_StepOut, 0, 179 } /* seqPointIndex: 179 */,
	{ 54905, 5, 98, 98, 13, 112, 27, kSequencePointKind_StepOut, 0, 180 } /* seqPointIndex: 180 */,
	{ 54905, 5, 99, 99, 13, 38, 33, kSequencePointKind_Normal, 0, 181 } /* seqPointIndex: 181 */,
	{ 54905, 5, 100, 100, 9, 10, 37, kSequencePointKind_Normal, 0, 182 } /* seqPointIndex: 182 */,
	{ 54906, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 183 } /* seqPointIndex: 183 */,
	{ 54906, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 184 } /* seqPointIndex: 184 */,
	{ 54906, 5, 515, 515, 9, 10, 0, kSequencePointKind_Normal, 0, 185 } /* seqPointIndex: 185 */,
	{ 54906, 5, 517, 517, 13, 52, 1, kSequencePointKind_Normal, 0, 186 } /* seqPointIndex: 186 */,
	{ 54906, 5, 517, 517, 0, 0, 11, kSequencePointKind_Normal, 0, 187 } /* seqPointIndex: 187 */,
	{ 54906, 5, 518, 518, 17, 29, 14, kSequencePointKind_Normal, 0, 188 } /* seqPointIndex: 188 */,
	{ 54906, 5, 520, 520, 13, 55, 18, kSequencePointKind_Normal, 0, 189 } /* seqPointIndex: 189 */,
	{ 54906, 5, 520, 520, 0, 0, 28, kSequencePointKind_Normal, 0, 190 } /* seqPointIndex: 190 */,
	{ 54906, 5, 521, 521, 17, 82, 31, kSequencePointKind_Normal, 0, 191 } /* seqPointIndex: 191 */,
	{ 54906, 5, 521, 521, 17, 82, 33, kSequencePointKind_StepOut, 0, 192 } /* seqPointIndex: 192 */,
	{ 54906, 5, 522, 522, 13, 50, 43, kSequencePointKind_Normal, 0, 193 } /* seqPointIndex: 193 */,
	{ 54906, 5, 523, 523, 9, 10, 52, kSequencePointKind_Normal, 0, 194 } /* seqPointIndex: 194 */,
	{ 54907, 0, 0, 0, 0, 0, -1, kSequencePointKind_Normal, 0, 195 } /* seqPointIndex: 195 */,
	{ 54907, 0, 0, 0, 0, 0, 16777215, kSequencePointKind_Normal, 0, 196 } /* seqPointIndex: 196 */,
	{ 54907, 5, 528, 528, 9, 10, 0, kSequencePointKind_Normal, 0, 197 } /* seqPointIndex: 197 */,
	{ 54907, 5, 529, 529, 13, 90, 1, kSequencePointKind_Normal, 0, 198 } /* seqPointIndex: 198 */,
	{ 54907, 5, 529, 529, 13, 90, 10, kSequencePointKind_StepOut, 0, 199 } /* seqPointIndex: 199 */,
	{ 54907, 5, 530, 530, 13, 52, 15, kSequencePointKind_Normal, 0, 200 } /* seqPointIndex: 200 */,
	{ 54907, 5, 530, 530, 13, 52, 22, kSequencePointKind_StepOut, 0, 201 } /* seqPointIndex: 201 */,
	{ 54907, 5, 531, 531, 9, 10, 28, kSequencePointKind_Normal, 0, 202 } /* seqPointIndex: 202 */,
};
#else
extern Il2CppSequencePoint g_sequencePointsUnityEngine_VFXModule[];
Il2CppSequencePoint g_sequencePointsUnityEngine_VFXModule[1] = { { 0, 0, 0, 0, 0, 0, 0, kSequencePointKind_Normal, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#else
static const Il2CppCatchPoint g_catchPoints[1] = { { 0, 0, 0, 0, } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[] = {
{ "", { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0} }, //0 
{ "C:\\build\\output\\unity\\unity\\Modules\\VFX\\Public\\ScriptBindings\\VFXEventAttribute.bindings.cs", { 85, 240, 140, 59, 226, 24, 230, 200, 194, 228, 102, 200, 59, 62, 252, 109} }, //1 
{ "C:\\build\\output\\unity\\unity\\Modules\\VFX\\Public\\ScriptBindings\\VFXExpressionValues.bindings.cs", { 137, 94, 30, 16, 81, 236, 48, 215, 52, 194, 54, 215, 195, 215, 95, 88} }, //2 
{ "C:\\build\\output\\unity\\unity\\Modules\\VFX\\Public\\ScriptBindings\\VFXManager.bindings.cs", { 218, 16, 69, 254, 104, 12, 154, 76, 202, 231, 166, 116, 60, 143, 159, 84} }, //3 
{ "C:\\build\\output\\unity\\unity\\Modules\\VFX\\Public\\ScriptBindings\\VFXSpawnerState.bindings.cs", { 214, 51, 101, 240, 207, 151, 49, 7, 90, 22, 249, 133, 43, 200, 138, 117} }, //4 
{ "C:\\build\\output\\unity\\unity\\Modules\\VFX\\Public\\ScriptBindings\\VisualEffect.bindings.cs", { 85, 202, 198, 34, 205, 172, 109, 144, 118, 44, 122, 136, 213, 22, 79, 193} }, //5 
};
#else
static const Il2CppSequencePointSourceFile g_sequencePointSourceFiles[1] = { NULL, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppTypeSourceFilePair g_typeSourceFiles[7] = 
{
	{ 7870, 1 },
	{ 7871, 2 },
	{ 7873, 3 },
	{ 7875, 4 },
	{ 7877, 5 },
	{ 7878, 5 },
	{ 7879, 5 },
};
#else
static const Il2CppTypeSourceFilePair g_typeSourceFiles[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodScope g_methodScopes[13] = 
{
	{ 0, 20 },
	{ 0, 30 },
	{ 0, 28 },
	{ 0, 65 },
	{ 0, 20 },
	{ 0, 39 },
	{ 0, 26 },
	{ 0, 58 },
	{ 0, 67 },
	{ 0, 65 },
	{ 0, 39 },
	{ 0, 54 },
	{ 0, 29 },
};
#else
static const Il2CppMethodScope g_methodScopes[1] = { { 0, 0 } };
#endif
#if IL2CPP_MONO_DEBUGGER
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[33] = 
{
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXEventAttribute::.ctor(System.IntPtr,System.Boolean,UnityEngine.VFX.VisualEffectAsset) */,
	{ 20, 0, 1 } /* UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VFXEventAttribute::CreateEventAttributeWrapper() */,
	{ 30, 1, 1 } /* System.Void UnityEngine.VFX.VFXEventAttribute::SetWrapValue(System.IntPtr) */,
	{ 0, 0, 0 } /* System.IntPtr UnityEngine.VFX.VFXEventAttribute::Internal_Create() */,
	{ 28, 2, 1 } /* UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VFXEventAttribute::Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXEventAttribute::Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset) */,
	{ 65, 3, 1 } /* System.Void UnityEngine.VFX.VFXEventAttribute::Release() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXEventAttribute::Finalize() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXEventAttribute::Dispose() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXEventAttribute::Internal_Destroy(System.IntPtr) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXExpressionValues::.ctor() */,
	{ 20, 4, 1 } /* UnityEngine.VFX.VFXExpressionValues UnityEngine.VFX.VFXExpressionValues::CreateExpressionValuesWrapper(System.IntPtr) */,
	{ 39, 5, 1 } /* System.Void UnityEngine.VFX.VFXManager::.cctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnPlay(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnUpdate(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerCallbacks::OnStop(UnityEngine.VFX.VFXSpawnerState,UnityEngine.VFX.VFXExpressionValues,UnityEngine.VFX.VisualEffect) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerCallbacks::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerState::.ctor(System.IntPtr,System.Boolean) */,
	{ 26, 6, 1 } /* UnityEngine.VFX.VFXSpawnerState UnityEngine.VFX.VFXSpawnerState::CreateSpawnerStateWrapper() */,
	{ 58, 7, 1 } /* System.Void UnityEngine.VFX.VFXSpawnerState::PrepareWrapper() */,
	{ 67, 8, 1 } /* System.Void UnityEngine.VFX.VFXSpawnerState::SetWrapValue(System.IntPtr,System.IntPtr) */,
	{ 65, 9, 1 } /* System.Void UnityEngine.VFX.VFXSpawnerState::Release() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerState::Finalize() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerState::Dispose() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXSpawnerState::Internal_Destroy(System.IntPtr) */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VisualEffectObject::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VisualEffectAsset::.ctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VisualEffectAsset::.cctor() */,
	{ 0, 0, 0 } /* System.Void UnityEngine.VFX.VFXOutputEventArgs::.ctor(System.Int32,UnityEngine.VFX.VFXEventAttribute) */,
	{ 0, 0, 0 } /* UnityEngine.VFX.VisualEffectAsset UnityEngine.VFX.VisualEffect::get_visualEffectAsset() */,
	{ 39, 10, 1 } /* UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VisualEffect::CreateVFXEventAttribute() */,
	{ 54, 11, 1 } /* UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VisualEffect::InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect) */,
	{ 29, 12, 1 } /* System.Void UnityEngine.VFX.VisualEffect::InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect,System.Int32) */,
};
#else
static const Il2CppMethodHeaderInfo g_methodHeaderInfos[1] = { { 0, 0, 0 } };
#endif
IL2CPP_EXTERN_C const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_VFXModule;
const Il2CppDebuggerMetadataRegistration g_DebuggerMetadataRegistrationUnityEngine_VFXModule = 
{
	(Il2CppMethodExecutionContextInfo*)g_methodExecutionContextInfos,
	(Il2CppMethodExecutionContextInfoIndex*)g_methodExecutionContextInfoIndexes,
	(Il2CppMethodScope*)g_methodScopes,
	(Il2CppMethodHeaderInfo*)g_methodHeaderInfos,
	(Il2CppSequencePointSourceFile*)g_sequencePointSourceFiles,
	203,
	(Il2CppSequencePoint*)g_sequencePointsUnityEngine_VFXModule,
	0,
	(Il2CppCatchPoint*)g_catchPoints,
	7,
	(Il2CppTypeSourceFilePair*)g_typeSourceFiles,
	(const char**)g_methodExecutionContextInfoStrings,
};
