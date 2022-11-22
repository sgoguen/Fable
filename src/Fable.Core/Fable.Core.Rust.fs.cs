// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../quicktest-csharp/fable_modules/fable-library.4.0.0-theta-018/Types.js' as types;

class ByRefAttribute extends Attribute {
    ByRefAttribute(): super();
}

class OuterAttrAttribute extends Attribute {
    OuterAttrAttribute(String name, types.Some<String>? value, List<String> items): super();
}

OuterAttrAttribute OuterAttrAttribute_$ctor_Z721C83C5(String name) {
}

OuterAttrAttribute OuterAttrAttribute_$ctor_Z384F8060(String name, String value) {
}

OuterAttrAttribute OuterAttrAttribute_$ctor_Z7F9E8555(String name, List<String> items) {
}

class InnerAttrAttribute extends Attribute {
    InnerAttrAttribute(String name, types.Some<String>? value, List<String> items): super();
}

InnerAttrAttribute InnerAttrAttribute_$ctor_Z721C83C5(String name) {
}

InnerAttrAttribute InnerAttrAttribute_$ctor_Z384F8060(String name, String value) {
}

InnerAttrAttribute InnerAttrAttribute_$ctor_Z7F9E8555(String name, List<String> items) {
}

class ReferenceTypeAttribute extends Attribute {
    ReferenceTypeAttribute(int pointerType): super();
}

T emitExpr<T>(dynamic args, String code) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

T import$<T>(String selector, String path) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

T importAll<T>(String path) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

