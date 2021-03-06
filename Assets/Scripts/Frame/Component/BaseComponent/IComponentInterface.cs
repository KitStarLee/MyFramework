﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

// 会修改位置的组件
public interface IComponentModifyPosition
{ }

// 会修改旋转的组件
public interface IComponentModifyRotation
{ }

// 会修改缩放的组件
public interface IComponentModifyScale
{ }

// 会修改透明度的组件
public interface IComponentModifyAlpha
{ }

// 能够被其他组件中断的组件
public interface IComponentBreakable
{
	void notifyBreak();
}