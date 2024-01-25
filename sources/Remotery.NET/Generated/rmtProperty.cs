namespace RemoteryNET;

/// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty"]/*' />
public unsafe partial struct rmtProperty
{
    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.initialised"]/*' />
    [NativeTypeName("rmtBool")]
    public uint initialised;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.type"]/*' />
    public rmtPropertyType type;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.flags"]/*' />
    public rmtPropertyFlags flags;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.value"]/*' />
    public rmtPropertyValue value;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.lastFrameValue"]/*' />
    public rmtPropertyValue lastFrameValue;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.prevValue"]/*' />
    public rmtPropertyValue prevValue;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.prevValueFrame"]/*' />
    [NativeTypeName("rmtU32")]
    public uint prevValueFrame;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* name;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.description"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* description;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.defaultValue"]/*' />
    public rmtPropertyValue defaultValue;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.parent"]/*' />
    [NativeTypeName("struct rmtProperty *")]
    public rmtProperty* parent;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.firstChild"]/*' />
    [NativeTypeName("struct rmtProperty *")]
    public rmtProperty* firstChild;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.lastChild"]/*' />
    [NativeTypeName("struct rmtProperty *")]
    public rmtProperty* lastChild;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.nextSibling"]/*' />
    [NativeTypeName("struct rmtProperty *")]
    public rmtProperty* nextSibling;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.nameHash"]/*' />
    [NativeTypeName("rmtU32")]
    public uint nameHash;

    /// <include file='rmtProperty.xml' path='doc/member[@name="rmtProperty.uniqueID"]/*' />
    [NativeTypeName("rmtU32")]
    public uint uniqueID;
}
