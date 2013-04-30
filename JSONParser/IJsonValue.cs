using System;

public interface IJsonValue 
		: IEquatable<IJsonValue>
	{
	IJsonValue this[string key] {
		get;
		set;
	}
	string ToString();
	string ToJson();
	//string ToRepr();
	//IJsonValue this[int i] {
	//	get;
	//	set;
	//}
	object Value { 
		get;
	}
}
