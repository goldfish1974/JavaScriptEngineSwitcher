﻿namespace JavaScriptEngineSwitcher.Tests.V8
{
	using Core;

	public class Es5Tests : Es5TestsBase
	{
		protected override IJsEngine CreateJsEngine()
		{
			var jsEngine = JsEngineSwitcher.Current.CreateJsEngineInstance("V8JsEngine");

			return jsEngine;
		}
	}
}