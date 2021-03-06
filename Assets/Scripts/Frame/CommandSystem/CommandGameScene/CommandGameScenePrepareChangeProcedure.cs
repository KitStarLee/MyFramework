﻿using System;
using System.Collections;

public class CommandGameScenePrepareChangeProcedure : Command
{
	public Type mProcedure;
	public string mIntent;
	public float mPrepareTime;
	public override void init()
	{
		base.init();
		mProcedure = null;
		mIntent = null;
		mPrepareTime = -1.0f;
	}
	public override void execute()
	{
		GameScene gameScene = mReceiver as GameScene;
		// 准备时间必须大于0
		if (mPrepareTime <= 0.0f)
		{
			logError("preapare time must be larger than 0!");
			return;
		}
		// 正在准备跳转时,不允许再次准备跳转
		SceneProcedure curProcedure = gameScene.getCurProcedure();
		if (curProcedure.isPreparingExit())
		{
			logError("procedure is preparing to exit, can not prepare again!");
			return;
		}
		gameScene.prepareChangeProcedure(mProcedure, mPrepareTime, mIntent);
	}
	public override string showDebugInfo()
	{
		string procedure = mProcedure != null ? mProcedure.ToString() : "null";
		string intent = mIntent != null ? mIntent : "";
		return base.showDebugInfo() + ": mProcedure:" + procedure + ", mIntent:" + intent + ", mPrepareTime:" + mPrepareTime;
	}
}