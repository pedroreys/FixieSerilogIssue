# FixieSerilogIssue

Run the test with VS Runner and you will get an Assembly Binding Issue

````
------ Discover test started ------
Fixie 1.0.0.33
Processing C:\dev\FixieSerilogIssue\CoreTest\bin\Debug\CoreTest.dll
========== Discover test finished: 1 found (0:00:00.2361091) ==========
------ Run test started ------
Fixie 1.0.0.33
Processing C:\dev\FixieSerilogIssue\CoreTest\bin\Debug\CoreTest.dll
System.Runtime.Serialization.SerializationException: Unable to find assembly 'Serilog.FullNetFx, Version=1.5.0.0, Culture=neutral, PublicKeyToken=24c2f752a8e58a10'.

Server stack trace: 
   at System.Runtime.Serialization.Formatters.Binary.BinaryAssemblyInfo.GetAssembly()
   at System.Runtime.Serialization.Formatters.Binary.ObjectReader.GetType(BinaryAssemblyInfo assemblyInfo, String name)
   at System.Runtime.Serialization.Formatters.Binary.ObjectMap..ctor(String objectName, String[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, Object[] typeInformationA, Int32[] memberAssemIds, ObjectReader objectReader, Int32 objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
   at System.Runtime.Serialization.Formatters.Binary.__BinaryParser.ReadObjectWithMapTyped(BinaryObjectWithMapTyped record)
   at System.Runtime.Serialization.Formatters.Binary.__BinaryParser.ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
   at System.Runtime.Serialization.Formatters.Binary.__BinaryParser.Run()
   at System.Runtime.Serialization.Formatters.Binary.ObjectReader.Deserialize(HeaderHandler handler, __BinaryParser serParser, Boolean fCheck, Boolean isCrossAppDomain, IMethodCallMessage methodCallMessage)
   at System.Runtime.Serialization.Formatters.Binary.BinaryFormatter.Deserialize(Stream serializationStream, HeaderHandler handler, Boolean fCheck, Boolean isCrossAppDomain, IMethodCallMessage methodCallMessage)
   at System.Runtime.Remoting.Channels.CrossAppDomainSerializer.DeserializeObject(MemoryStream stm)
   at System.Runtime.Remoting.Messaging.SmuggledMethodCallMessage.FixupForNewAppDomain()
   at System.Runtime.Remoting.Channels.CrossAppDomainSink.DoDispatch(Byte[] reqStmBuff, SmuggledMethodCallMessage smuggledMcm, SmuggledMethodReturnMessage& smuggledMrm)
   at System.Runtime.Remoting.Channels.CrossAppDomainSink.DoTransitionDispatchCallback(Object[] args)

Exception rethrown at [0]: 
   at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
   at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
   at Fixie.Execution.Listener.CasePassed(PassResult result)
   at Fixie.Internal.ClassRunner.Pass(Case case)
   at Fixie.Internal.ClassRunner.Run(Type testClass)
   at Fixie.Internal.Runner.Run(Convention convention, Type[] candidateTypes)
   at Fixie.Internal.Runner.Run(Assembly assembly, IEnumerable`1 conventions, Type[] candidateTypes)
   at Fixie.Internal.Runner.RunAssembly(Assembly assembly)
   at Fixie.Internal.ExecutionProxy.RunAssembly(String assemblyFullPath, Options options, Listener listener)
   at System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
   at System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)

Exception rethrown at [1]: 
   at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
   at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
   at Fixie.Internal.ExecutionProxy.RunAssembly(String assemblyFullPath, Options options, Listener listener)
   at Fixie.Execution.ExecutionEnvironment.RunAssembly(Options options, Listener listener)
   at Fixie.VisualStudio.TestAdapter.VsTestExecutor.RunTests(IEnumerable`1 sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
No test is available in C:\dev\FixieSerilogIssue\CoreTest\bin\Debug\CoreTest.dll. Make sure that installed test discoverers & executors, platform & framework version settings are appropriate and try again.
========== Run test finished: 0 run (0:00:09.3419569) ==========
````
