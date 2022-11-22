// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../quicktest-csharp/fable_modules/fable-library.4.0.0-theta-018/Types.js' as types;

abstract class DecoratorAttribute extends Attribute {
    DecoratorAttribute(): super();
    Callable Decorate(Callable fn);
}

abstract class ReflectedDecoratorAttribute extends Attribute {
    ReflectedDecoratorAttribute(): super();
    Callable Decorate(Callable fn, MethodInfo info);
}

abstract class ArrayConstructor {
    List<T> Create<T>(int size);
    List<T> from<T>(dynamic arg);
    bool isArray(dynamic arg);
}

abstract class ArrayBuffer$ {
    int get byteLength;
    ArrayBuffer slice(int begin, types.Some<int>? end);
}

T python<T>(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

T expr_python<T>(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

