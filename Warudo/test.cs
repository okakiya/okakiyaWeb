using UnityEngine;
using Warudo.Core.Attributes;
using Warudo.Core.Data;
using Warudo.Core.Graphs;
using Warudo.Core.Localization;
using System.Collections.Generic;
using System;
using Warudo.Core.Plugins;

[NodeType(
    Id = "UIDを発行して入力すること",
    Title = "TestNode",
    Category = "TestCategory"
)]
public class TestNode : Node
{
    [DataInput]
    [Label("TestInput")]
    public int TestInput = 1;

    [DataOutput]
    [Label("TestOutput")]
    public int TestOutput() { return OutputItem; }
    public int OutputItem = 0;

    protected override void OnCreate()
    {
        base.OnCreate();
        Test();
    }

    public void Test()
    {
        OutputItem = TestInput + 1;
    }
}

[PluginType(
    Id = "okakiya.testnode",
    Name = "TestMOD",
    Description = "Test description.",
    Version = "1.0.0",
    Author = "okakiya",
    SupportUrl = "",
    NodeTypes = new [] { typeof(TestNode) })] // 各Nodeを入力
public class TestPlugin : Plugin {

    protected override void OnCreate() {
        base.OnCreate();
        Debug.Log("The Test plugin is officially enabled! Hooray!");
    }

}
