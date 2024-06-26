﻿namespace Mono.Documentation.Updater
{
    public interface IAttributeParserContext
    {
        void NextDynamicFlag();
        bool IsDynamic();
        bool IsNullable();
        string GetTupleElementName();
        bool IsNativeInteger();
    }
}
