// ignore_for_file: camel_case_types, constant_identifier_names, non_constant_identifier_names, unnecessary_this
import '../quicktest-csharp/fable_modules/fable-library.4.0.0-theta-018/List.js' as list;
import '../quicktest-csharp/fable_modules/fable-library.4.0.0-theta-018/Types.js' as types;

class JSX_ComponentAttribute extends Attribute {
    JSX_ComponentAttribute(): super();
}

class JSX_Element {
}

Element JSX_create(dynamic componentOrTag, list.FSharpList<types.Tuple2<String, dynamic>> props) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

Element JSX_html(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

Element JSX_jsx(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

Element JSX_text(String text) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

final JSX_nothing = throw Exception('A function supposed to be replaced by native code has been called, please check.');

class JS_RemoveSurroundingArgsAttribute extends Attribute {
    JS_RemoveSurroundingArgsAttribute(): super();
}

class JS_WrapSurroundingFunctionAttribute extends Attribute {
    JS_WrapSurroundingFunctionAttribute(): super();
}

abstract class JS_Function {
    dynamic Create(List<dynamic> args);
    dynamic Invoke(List<dynamic> args);
    dynamic apply(dynamic thisArg, List<dynamic> args);
    Function bind(dynamic thisArg, List<dynamic> args);
    dynamic call(dynamic thisArg, List<dynamic> args);
    int get length;
    String get name;
}

abstract class JS_DecoratorAttribute extends Attribute {
    JS_DecoratorAttribute(): super();
    Function Decorate(Function fn);
}

abstract class JS_ReflectedDecoratorAttribute extends Attribute {
    JS_ReflectedDecoratorAttribute(): super();
    Function Decorate(Function fn, MethodInfo info);
}

abstract class JS_PropertyDescriptor {
    dynamic get();
    types.Some<bool>? get configurable;
    types.Some<bool>? get enumerable;
    types.Some<dynamic>? get value;
    types.Some<bool>? get writable;
    void set(dynamic v);
    void set configurable(types.Some<bool>? arg0$) ;
    void set enumerable(types.Some<bool>? arg0$) ;
    void set value(types.Some<dynamic>? arg0$) ;
    void set writable(types.Some<bool>? arg0$) ;
}

abstract class JS_ArrayConstructor {
    List<T> Create<T>(int size);
    List<T> from<T>(dynamic arg);
    bool isArray(dynamic arg);
}

abstract class JS_NumberConstructor {
    bool isNaN(double arg0$);
}

abstract class JS_Object {
    bool hasOwnProperty(String v);
    bool hasOwnProperty(dynamic v);
    bool isPrototypeOf(dynamic v);
    bool propertyIsEnumerable(String v);
    bool propertyIsEnumerable(dynamic v);
    String toLocaleString();
    String toString();
    dynamic valueOf();
}

abstract class JS_ObjectConstructor {
    dynamic assign<T, U>(T target, U source);
    dynamic assign<T, U, V>(T target, U source1, V source2);
    dynamic assign<T, U, V, W>(T target, U source1, V source2, W source3);
    dynamic assign(dynamic target, List<dynamic> sources);
    dynamic create(dynamic o, types.Some<dynamic>? properties);
    dynamic defineProperties(dynamic o, dynamic properties);
    dynamic defineProperty(dynamic o, String p, PropertyDescriptor attributes);
    dynamic defineProperty(dynamic o, dynamic propertyKey, PropertyDescriptor attributes);
    List<types.Tuple2<String, dynamic>> entries(dynamic o);
    T freeze<T>(T o);
    PropertyDescriptor getOwnPropertyDescriptor(dynamic o, String p);
    PropertyDescriptor getOwnPropertyDescriptor(dynamic o, dynamic propertyKey);
    List<String> getOwnPropertyNames(dynamic o);
    dynamic getPrototypeOf(dynamic o);
    bool is(dynamic value1, dynamic value2);
    bool isExtensible(dynamic o);
    bool isFrozen(dynamic o);
    bool isSealed(dynamic o);
    List<String> keys(dynamic o);
    T preventExtensions<T>(T o);
    T seal<T>(T o);
    dynamic setPrototypeOf(dynamic o, dynamic proto);
    List<dynamic> values(dynamic o);
}

abstract class JS_Math {
    double abs(double x);
    double acos(double x);
    double acosh(double x);
    double asin(double x);
    double asinh(double x);
    double atan(double x);
    double atan2(double y, double x);
    double atanh(double x);
    double cbrt(double x);
    double ceil(double x);
    double clz32(double x);
    double cos(double x);
    double cosh(double x);
    double exp(double x);
    double expm1(double x);
    double floor(double x);
    double fround(double x);
    double get E;
    double get LN10;
    double get LN2;
    double get LOG10E;
    double get LOG2E;
    double get PI;
    double get SQRT1_2;
    double get SQRT2;
    double hypot(List<double> values);
    double imul(double x, double y);
    double log(double x);
    double log10(double x);
    double log1p(double x);
    double log2(double x);
    double max(List<double> values);
    double min(List<double> values);
    double pow(double x, double y);
    double random();
    double round(double x);
    double sign(double x);
    double sin(double x);
    double sinh(double x);
    double sqrt(double x);
    double tan(double x);
    double tanh(double x);
    double trunc(double x);
}

abstract class JS_Date {
    double getDate();
    double getDay();
    double getFullYear();
    double getHours();
    double getMilliseconds();
    double getMinutes();
    double getMonth();
    double getSeconds();
    double getTime();
    double getTimezoneOffset();
    double getUTCDate();
    double getUTCDay();
    double getUTCFullYear();
    double getUTCHours();
    double getUTCMilliseconds();
    double getUTCMinutes();
    double getUTCMonth();
    double getUTCSeconds();
    double setDate(double date);
    double setFullYear(double year, types.Some<double>? month, types.Some<double>? date);
    double setHours(double hours, types.Some<double>? min, types.Some<double>? sec, types.Some<double>? ms);
    double setMilliseconds(double ms);
    double setMinutes(double min, types.Some<double>? sec, types.Some<double>? ms);
    double setMonth(double month, types.Some<double>? date);
    double setSeconds(double sec, types.Some<double>? ms);
    double setTime(double time);
    double setUTCDate(double date);
    double setUTCFullYear(double year, types.Some<double>? month, types.Some<double>? date);
    double setUTCHours(double hours, types.Some<double>? min, types.Some<double>? sec, types.Some<double>? ms);
    double setUTCMilliseconds(double ms);
    double setUTCMinutes(double min, types.Some<double>? sec, types.Some<double>? ms);
    double setUTCMonth(double month, types.Some<double>? date);
    double setUTCSeconds(double sec, types.Some<double>? ms);
    String toDateString();
    String toISOString();
    String toJSON(types.Some<dynamic>? key);
    String toLocaleDateString();
    String toLocaleString();
    String toLocaleTimeString();
    String toString();
    String toTimeString();
    String toUTCString();
    double valueOf();
}

abstract class JS_DateConstructor {
    DateTime Create();
    DateTime Create(double value);
    DateTime Create(String value);
    DateTime Create(double year, double month, types.Some<double>? date, types.Some<double>? hours, types.Some<double>? minutes, types.Some<double>? seconds, types.Some<double>? ms);
    String Invoke();
    double UTC(double year, double month, types.Some<double>? date, types.Some<double>? hours, types.Some<double>? minutes, types.Some<double>? seconds, types.Some<double>? ms);
    double now();
    double parse(String s);
}

abstract class JS_JSON {
    dynamic parse(String text, types.Some<dynamic Function(dynamic) Function(dynamic)>? reviver);
    String stringify(dynamic value, types.Some<dynamic Function(dynamic) Function(String)>? replacer, types.Some<dynamic>? space);
}

abstract class JS_Map$2<K, V> {
    void clear();
    bool delete(K key);
    Iterable<types.Tuple2<K, V>> entries();
    void forEach(void Function(Map<K, V>) Function(K) Function(V) callbackfn, types.Some<dynamic>? thisArg);
    V get(K key);
    int get size;
    bool has(K key);
    Iterable<K> keys();
    Map<K, V> set(K key, V value);
    Iterable<V> values();
}

abstract class JS_MapConstructor {
    Map<K, V> Create<K, V>(types.Some<Iterable<types.Tuple2<K, V>>>? iterable);
}

abstract class JS_WeakMap$2<K, V> {
    void clear();
    bool delete(K key);
    V get(K key);
    bool has(K key);
    WeakMap<K, V> set(K key, V value);
}

abstract class JS_WeakMapConstructor {
    WeakMap<K, V> Create<K, V>(types.Some<Iterable<types.Tuple2<K, V>>>? iterable);
}

abstract class JS_Set$1<T> {
    Set<T> add(T value);
    void clear();
    bool delete(T value);
    Iterable<types.Tuple2<T, T>> entries();
    void forEach(void Function(Set<T>) Function(T) Function(T) callbackfn, types.Some<dynamic>? thisArg);
    int get size;
    bool has(T value);
    Iterable<T> keys();
    Iterable<T> values();
}

abstract class JS_SetConstructor {
    Set<T> Create<T>(types.Some<Iterable<T>>? iterable);
}

abstract class JS_WeakSet$1<T> {
    WeakSet<T> add(T value);
    void clear();
    bool delete(T value);
    bool has(T value);
}

abstract class JS_WeakSetConstructor {
    WeakSet<T> Create<T>(types.Some<Iterable<T>>? iterable);
}

abstract class JS_AsyncIterable {
}

abstract class JS_AsyncIterable$1<T> {
}

abstract class JS_Promise$1<T> {
    Promise<T> catch(types.Some<T Function(dynamic)>? onrejected);
    Promise<TResult> then<TResult>(types.Some<TResult Function(T)>? onfulfilled, types.Some<TResult Function(dynamic)>? onrejected);
}

abstract class JS_PromiseConstructor {
    Promise<T> Create<T>(void Function(void Function(dynamic)) Function(void Function(dynamic)) executor);
    Promise<dynamic> all(List<dynamic> values);
    Promise<dynamic> race(Iterable<dynamic> values);
    Promise<void> reject(dynamic reason);
    Promise<T> reject<T>(dynamic reason);
    Promise<T> resolve<T>(T value);
    Promise<void> resolve();
}

abstract class JS_RegExpConstructor {
    RegExp Create(String pattern, types.Some<String>? flags);
}

abstract class JS_ArrayBuffer {
    int get byteLength;
    ArrayBuffer slice(int begin, types.Some<int>? end);
}

abstract class JS_ArrayBufferConstructor {
    ArrayBuffer Create(int byteLength);
    bool isView(dynamic arg);
}

abstract class JS_ArrayBufferView {
    ArrayBuffer get buffer;
    int get byteLength;
    int get byteOffset;
}

abstract class JS_ArrayBufferViewConstructor {
    ArrayBufferView Create(int size);
}

abstract class JS_DataView {
    double getFloat32(int byteOffset, types.Some<bool>? littleEndian);
    double getFloat64(int byteOffset, types.Some<bool>? littleEndian);
    int getInt16(int byteOffset, types.Some<bool>? littleEndian);
    int getInt32(int byteOffset, types.Some<bool>? littleEndian);
    int getInt8(int byteOffset);
    int getUint16(int byteOffset, types.Some<bool>? littleEndian);
    int getUint32(int byteOffset, types.Some<bool>? littleEndian);
    int getUint8(int byteOffset);
    ArrayBuffer get buffer;
    int get byteLength;
    int get byteOffset;
    void setFloat32(int byteOffset, double value, types.Some<bool>? littleEndian);
    void setFloat64(int byteOffset, double value, types.Some<bool>? littleEndian);
    void setInt16(int byteOffset, int value, types.Some<bool>? littleEndian);
    void setInt32(int byteOffset, int value, types.Some<bool>? littleEndian);
    void setInt8(int byteOffset, int value);
    void setUint16(int byteOffset, int value, types.Some<bool>? littleEndian);
    void setUint32(int byteOffset, int value, types.Some<bool>? littleEndian);
    void setUint8(int byteOffset, int value);
}

abstract class JS_DataViewConstructor {
    DataView Create(ArrayBuffer buffer, types.Some<int>? byteOffset, types.Some<double>? byteLength);
}

abstract class JS_TypedArray {
    void copyWithin(int targetStartIndex, int start, types.Some<int>? end);
    dynamic entries();
    ArrayBuffer get buffer;
    int get byteLength;
    int get byteOffset;
    int get length;
    String join(String separator);
    dynamic keys();
}

abstract class JS_TypedArray$1<T> {
    TypedArray<T> fill(T value, types.Some<int>? begin, types.Some<int>? end);
    TypedArray<T> filter(bool Function(TypedArray<T>) Function(int) Function(T) arg0$);
    TypedArray<T> filter(bool Function(int) Function(T) arg0$);
    TypedArray<T> filter(bool Function(T) arg0$);
    types.Some<T>? find(bool Function(TypedArray<T>) Function(int) Function(T) arg0$);
    types.Some<T>? find(bool Function(int) Function(T) arg0$);
    types.Some<T>? find(bool Function(T) arg0$);
    int findIndex(bool Function(TypedArray<T>) Function(int) Function(T) arg0$);
    int findIndex(bool Function(int) Function(T) arg0$);
    int findIndex(bool Function(T) arg0$);
    void forEach(bool Function(TypedArray<T>) Function(int) Function(T) arg0$);
    void forEach(bool Function(int) Function(T) arg0$);
    void forEach(bool Function(T) arg0$);
    T Item(int index);
    bool includes(T searchElement, types.Some<int>? fromIndex);
    int indexOf(T searchElement, types.Some<int>? fromIndex);
    int lastIndexOf(T searchElement, types.Some<int>? fromIndex);
    TypedArray<U> map<U>(U Function(TypedArray<T>) Function(int) Function(T) arg0$);
    TypedArray<U> map<U>(U Function(int) Function(T) arg0$);
    TypedArray<U> map<U>(U Function(T) arg0$);
    State reduce<State>(State Function(TypedArray<T>) Function(int) Function(T) Function(State) arg0$, State state);
    State reduce<State>(State Function(int) Function(T) Function(State) arg0$, State state);
    State reduce<State>(State Function(T) Function(State) arg0$, State state);
    State reduceRight<State>(State Function(TypedArray<T>) Function(int) Function(T) Function(State) arg0$, State state);
    State reduceRight<State>(State Function(int) Function(T) Function(State) arg0$, State state);
    State reduceRight<State>(State Function(T) Function(State) arg0$, State state);
    TypedArray<T> reverse();
    void set(List<dynamic> source, types.Some<int>? offset);
    void set<$b extends TypedArray>($b source, types.Some<int>? offset);
    void Item(int index, T arg1$);
    TypedArray<T> slice(types.Some<int>? begin, types.Some<int>? end);
    bool some(bool Function(TypedArray<T>) Function(int) Function(T) arg0$);
    bool some(bool Function(int) Function(T) arg0$);
    bool some(bool Function(T) arg0$);
    TypedArray<T> sort(types.Some<int Function(T) Function(T)>? sortFunction);
    TypedArray<T> subarray(types.Some<int>? begin, types.Some<int>? end);
    dynamic values();
}

abstract class JS_Int8ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Uint8ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Uint8ClampedArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Int16ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Uint16ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Int32ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Uint32ArrayConstructor {
    TypedArray<int> Create(int size);
    TypedArray<int> Create(TypedArray typedArray);
    TypedArray<int> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<int> Create(dynamic data);
}

abstract class JS_Float32ArrayConstructor {
    TypedArray<double> Create(int size);
    TypedArray<double> Create(TypedArray typedArray);
    TypedArray<double> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<double> Create(dynamic data);
}

abstract class JS_Float64ArrayConstructor {
    TypedArray<double> Create(int size);
    TypedArray<double> Create(TypedArray typedArray);
    TypedArray<double> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<double> Create(dynamic data);
}

abstract class JS_BigInt64ArrayConstructor {
    TypedArray<dynamic> Create(int size);
    TypedArray<dynamic> Create(TypedArray typedArray);
    TypedArray<dynamic> Create(ArrayBuffer buffer, types.Some<int>? offset, types.Some<int>? length);
    TypedArray<dynamic> Create(dynamic data);
}

abstract class JS_Console {
    void assert(types.Some<bool>? test, types.Some<String>? message, List<dynamic> optionalParams);
    void clear();
    void count(types.Some<String>? countTitle);
    void debug(types.Some<String>? message, List<dynamic> optionalParams);
    void dir(types.Some<dynamic>? value, List<dynamic> optionalParams);
    void dirxml(dynamic value);
    void error(types.Some<dynamic>? message, List<dynamic> optionalParams);
    void group(types.Some<String>? groupTitle);
    void groupCollapsed(types.Some<String>? groupTitle);
    void groupEnd();
    void info(types.Some<dynamic>? message, List<dynamic> optionalParams);
    void log(types.Some<dynamic>? message, List<dynamic> optionalParams);
    void profile(types.Some<String>? reportName);
    void profileEnd();
    void table(types.Some<dynamic>? data);
    void time(types.Some<String>? timerName);
    void timeEnd(types.Some<String>? timerName);
    void trace(types.Some<dynamic>? message, List<dynamic> optionalParams);
    void warn(types.Some<dynamic>? message, List<dynamic> optionalParams);
}

T JS_js<T>(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

T JS_expr_js<T>(String template) => throw Exception('A function supposed to be replaced by native code has been called, please check.');

