
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using iECF;


[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("versionType", Namespace = "")]
public enum VersionType
{

    [System.Xml.Serialization.XmlEnumAttribute("1.0")]
    Version1,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorEnvioDiferidoType", Namespace = "")]
public enum IndicadorEnvioDiferidoType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorMontoGravadoType", Namespace = "")]
public enum IndicadorMontoGravadoType
{

    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TipoPagoType", Namespace = "")]
public enum TipoPagoType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Contado,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Credito,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Gratis,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("FormaPagoType", Namespace = "")]
public enum FormaPagoType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,

    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,

    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,

    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TipoCuentaPagoType", Namespace = "")]
public enum TipoCuentaPagoType
{

    CT,

    AH,

    OT,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorFacturacionType", Namespace = "")]
public enum IndicadorFacturacionType
{

    [System.Xml.Serialization.XmlEnumAttribute("0")]
    NoFacturable,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Itbis18,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Itbis16,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Itbis3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Exento,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorBienoServicioType", Namespace = "")]
public enum IndicadorBienoServicioType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Bien,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Servicio,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TipoDescuentoRecargoType", Namespace = "")]
public enum TipoDescuentoRecargoType
{

    [System.Xml.Serialization.XmlEnumAttribute("$")]
    Dollar,

    [System.Xml.Serialization.XmlEnumAttribute("%")]
    Percent,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TipoAjusteType", Namespace = "")]
public enum TipoAjusteType
{

    D,

    R,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorFacturacionDRType", Namespace = "")]
public enum IndicadorFacturacionDRType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CodigoModificacionType", Namespace = "")]
public enum CodigoModificacionType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TipoMonedaType", Namespace = "")]
public enum TipoMonedaType
{

    BRL,

    CAD,

    CHF,

    CHY,

    XDR,

    DKK,

    EUR,

    GBP,

    JPY,

    NOK,

    SCP,

    SEK,

    USD,

    VEF,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorNorma1007Type", Namespace = "")]
public enum IndicadorNorma1007Type
{

    [System.Xml.Serialization.XmlEnumAttribute("0")]
    Item0,

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IndicadorAgenteRetencionoPercepcionType", Namespace = "")]
public enum IndicadorAgenteRetencionoPercepcionType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CodificacionTipoImpuestosType", Namespace = "")]
public enum CodificacionTipoImpuestosType
{

    [System.Xml.Serialization.XmlEnumAttribute("001")]
    Item001,

    [System.Xml.Serialization.XmlEnumAttribute("002")]
    Item002,

    [System.Xml.Serialization.XmlEnumAttribute("003")]
    Item003,

    [System.Xml.Serialization.XmlEnumAttribute("004")]
    Item004,

    [System.Xml.Serialization.XmlEnumAttribute("005")]
    Item005,

    [System.Xml.Serialization.XmlEnumAttribute("006")]
    Item006,

    [System.Xml.Serialization.XmlEnumAttribute("007")]
    Item007,

    [System.Xml.Serialization.XmlEnumAttribute("008")]
    Item008,

    [System.Xml.Serialization.XmlEnumAttribute("009")]
    Item009,

    [System.Xml.Serialization.XmlEnumAttribute("010")]
    Item010,

    [System.Xml.Serialization.XmlEnumAttribute("011")]
    Item011,

    [System.Xml.Serialization.XmlEnumAttribute("012")]
    Item012,

    [System.Xml.Serialization.XmlEnumAttribute("013")]
    Item013,

    [System.Xml.Serialization.XmlEnumAttribute("014")]
    Item014,

    [System.Xml.Serialization.XmlEnumAttribute("015")]
    Item015,

    [System.Xml.Serialization.XmlEnumAttribute("016")]
    Item016,

    [System.Xml.Serialization.XmlEnumAttribute("017")]
    Item017,

    [System.Xml.Serialization.XmlEnumAttribute("018")]
    Item018,

    [System.Xml.Serialization.XmlEnumAttribute("019")]
    Item019,

    [System.Xml.Serialization.XmlEnumAttribute("020")]
    Item020,

    [System.Xml.Serialization.XmlEnumAttribute("021")]
    Item021,

    [System.Xml.Serialization.XmlEnumAttribute("022")]
    Item022,

    [System.Xml.Serialization.XmlEnumAttribute("023")]
    Item023,

    [System.Xml.Serialization.XmlEnumAttribute("024")]
    Item024,

    [System.Xml.Serialization.XmlEnumAttribute("025")]
    Item025,

    [System.Xml.Serialization.XmlEnumAttribute("026")]
    Item026,

    [System.Xml.Serialization.XmlEnumAttribute("027")]
    Item027,

    [System.Xml.Serialization.XmlEnumAttribute("028")]
    Item028,

    [System.Xml.Serialization.XmlEnumAttribute("029")]
    Item029,

    [System.Xml.Serialization.XmlEnumAttribute("030")]
    Item030,

    [System.Xml.Serialization.XmlEnumAttribute("031")]
    Item031,

    [System.Xml.Serialization.XmlEnumAttribute("032")]
    Item032,

    [System.Xml.Serialization.XmlEnumAttribute("033")]
    Item033,

    [System.Xml.Serialization.XmlEnumAttribute("034")]
    Item034,

    [System.Xml.Serialization.XmlEnumAttribute("035")]
    Item035,

    [System.Xml.Serialization.XmlEnumAttribute("036")]
    Item036,

    [System.Xml.Serialization.XmlEnumAttribute("037")]
    Item037,

    [System.Xml.Serialization.XmlEnumAttribute("038")]
    Item038,

    [System.Xml.Serialization.XmlEnumAttribute("039")]
    Item039,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UnidadMedidaType", Namespace = "")]
public enum UnidadMedidaType
{

    [System.Xml.Serialization.XmlEnumAttribute("1")]
    Item1,

    [System.Xml.Serialization.XmlEnumAttribute("2")]
    Item2,

    [System.Xml.Serialization.XmlEnumAttribute("3")]
    Item3,

    [System.Xml.Serialization.XmlEnumAttribute("4")]
    Item4,

    [System.Xml.Serialization.XmlEnumAttribute("5")]
    Item5,

    [System.Xml.Serialization.XmlEnumAttribute("6")]
    Item6,

    [System.Xml.Serialization.XmlEnumAttribute("7")]
    Item7,

    [System.Xml.Serialization.XmlEnumAttribute("8")]
    Item8,

    [System.Xml.Serialization.XmlEnumAttribute("9")]
    Item9,

    [System.Xml.Serialization.XmlEnumAttribute("10")]
    Item10,

    [System.Xml.Serialization.XmlEnumAttribute("11")]
    Item11,

    [System.Xml.Serialization.XmlEnumAttribute("12")]
    Item12,

    [System.Xml.Serialization.XmlEnumAttribute("13")]
    Item13,

    [System.Xml.Serialization.XmlEnumAttribute("14")]
    Item14,

    [System.Xml.Serialization.XmlEnumAttribute("15")]
    Item15,

    [System.Xml.Serialization.XmlEnumAttribute("16")]
    Item16,

    [System.Xml.Serialization.XmlEnumAttribute("17")]
    Item17,

    [System.Xml.Serialization.XmlEnumAttribute("18")]
    Item18,

    [System.Xml.Serialization.XmlEnumAttribute("19")]
    Item19,

    [System.Xml.Serialization.XmlEnumAttribute("20")]
    Item20,

    [System.Xml.Serialization.XmlEnumAttribute("21")]
    Item21,

    [System.Xml.Serialization.XmlEnumAttribute("22")]
    Item22,

    [System.Xml.Serialization.XmlEnumAttribute("23")]
    Item23,

    [System.Xml.Serialization.XmlEnumAttribute("24")]
    Item24,

    [System.Xml.Serialization.XmlEnumAttribute("25")]
    Item25,

    [System.Xml.Serialization.XmlEnumAttribute("26")]
    Item26,

    [System.Xml.Serialization.XmlEnumAttribute("27")]
    Item27,

    [System.Xml.Serialization.XmlEnumAttribute("28")]
    Item28,

    [System.Xml.Serialization.XmlEnumAttribute("29")]
    Item29,

    [System.Xml.Serialization.XmlEnumAttribute("30")]
    Item30,

    [System.Xml.Serialization.XmlEnumAttribute("31")]
    Item31,

    [System.Xml.Serialization.XmlEnumAttribute("32")]
    Item32,

    [System.Xml.Serialization.XmlEnumAttribute("33")]
    Item33,

    [System.Xml.Serialization.XmlEnumAttribute("34")]
    Item34,

    [System.Xml.Serialization.XmlEnumAttribute("35")]
    Item35,

    [System.Xml.Serialization.XmlEnumAttribute("36")]
    Item36,

    [System.Xml.Serialization.XmlEnumAttribute("37")]
    Item37,

    [System.Xml.Serialization.XmlEnumAttribute("38")]
    Item38,

    [System.Xml.Serialization.XmlEnumAttribute("39")]
    Item39,

    [System.Xml.Serialization.XmlEnumAttribute("40")]
    Item40,

    [System.Xml.Serialization.XmlEnumAttribute("41")]
    Item41,

    [System.Xml.Serialization.XmlEnumAttribute("42")]
    Item42,

    [System.Xml.Serialization.XmlEnumAttribute("43")]
    Item43,

    [System.Xml.Serialization.XmlEnumAttribute("44")]
    Item44,

    [System.Xml.Serialization.XmlEnumAttribute("45")]
    Item45,

    [System.Xml.Serialization.XmlEnumAttribute("46")]
    Item46,

    [System.Xml.Serialization.XmlEnumAttribute("47")]
    Item47,

    [System.Xml.Serialization.XmlEnumAttribute("48")]
    Item48,

    [System.Xml.Serialization.XmlEnumAttribute("49")]
    Item49,

    [System.Xml.Serialization.XmlEnumAttribute("50")]
    Item50,

    [System.Xml.Serialization.XmlEnumAttribute("51")]
    Item51,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ProvinciaMunicipioType", Namespace = "")]
public enum ProvinciaMunicipioType
{

    [System.Xml.Serialization.XmlEnumAttribute("010000")]
    Item010000,

    [System.Xml.Serialization.XmlEnumAttribute("010100")]
    Item010100,

    [System.Xml.Serialization.XmlEnumAttribute("010101")]
    Item010101,

    [System.Xml.Serialization.XmlEnumAttribute("020000")]
    Item020000,

    [System.Xml.Serialization.XmlEnumAttribute("020100")]
    Item020100,

    [System.Xml.Serialization.XmlEnumAttribute("020101")]
    Item020101,

    [System.Xml.Serialization.XmlEnumAttribute("020102")]
    Item020102,

    [System.Xml.Serialization.XmlEnumAttribute("020103")]
    Item020103,

    [System.Xml.Serialization.XmlEnumAttribute("020104")]
    Item020104,

    [System.Xml.Serialization.XmlEnumAttribute("020105")]
    Item020105,

    [System.Xml.Serialization.XmlEnumAttribute("020106")]
    Item020106,

    [System.Xml.Serialization.XmlEnumAttribute("020107")]
    Item020107,

    [System.Xml.Serialization.XmlEnumAttribute("020108")]
    Item020108,

    [System.Xml.Serialization.XmlEnumAttribute("020109")]
    Item020109,

    [System.Xml.Serialization.XmlEnumAttribute("020200")]
    Item020200,

    [System.Xml.Serialization.XmlEnumAttribute("020201")]
    Item020201,

    [System.Xml.Serialization.XmlEnumAttribute("020202")]
    Item020202,

    [System.Xml.Serialization.XmlEnumAttribute("020300")]
    Item020300,

    [System.Xml.Serialization.XmlEnumAttribute("020301")]
    Item020301,

    [System.Xml.Serialization.XmlEnumAttribute("020302")]
    Item020302,

    [System.Xml.Serialization.XmlEnumAttribute("020303")]
    Item020303,

    [System.Xml.Serialization.XmlEnumAttribute("020400")]
    Item020400,

    [System.Xml.Serialization.XmlEnumAttribute("020401")]
    Item020401,

    [System.Xml.Serialization.XmlEnumAttribute("020402")]
    Item020402,

    [System.Xml.Serialization.XmlEnumAttribute("020403")]
    Item020403,

    [System.Xml.Serialization.XmlEnumAttribute("020404")]
    Item020404,

    [System.Xml.Serialization.XmlEnumAttribute("020405")]
    Item020405,

    [System.Xml.Serialization.XmlEnumAttribute("020500")]
    Item020500,

    [System.Xml.Serialization.XmlEnumAttribute("020501")]
    Item020501,

    [System.Xml.Serialization.XmlEnumAttribute("020600")]
    Item020600,

    [System.Xml.Serialization.XmlEnumAttribute("020601")]
    Item020601,

    [System.Xml.Serialization.XmlEnumAttribute("020602")]
    Item020602,

    [System.Xml.Serialization.XmlEnumAttribute("020603")]
    Item020603,

    [System.Xml.Serialization.XmlEnumAttribute("020604")]
    Item020604,

    [System.Xml.Serialization.XmlEnumAttribute("020700")]
    Item020700,

    [System.Xml.Serialization.XmlEnumAttribute("020701")]
    Item020701,

    [System.Xml.Serialization.XmlEnumAttribute("020702")]
    Item020702,

    [System.Xml.Serialization.XmlEnumAttribute("020800")]
    Item020800,

    [System.Xml.Serialization.XmlEnumAttribute("020801")]
    Item020801,

    [System.Xml.Serialization.XmlEnumAttribute("020802")]
    Item020802,

    [System.Xml.Serialization.XmlEnumAttribute("020803")]
    Item020803,

    [System.Xml.Serialization.XmlEnumAttribute("020804")]
    Item020804,

    [System.Xml.Serialization.XmlEnumAttribute("020900")]
    Item020900,

    [System.Xml.Serialization.XmlEnumAttribute("020901")]
    Item020901,

    [System.Xml.Serialization.XmlEnumAttribute("021000")]
    Item021000,

    [System.Xml.Serialization.XmlEnumAttribute("021001")]
    Item021001,

    [System.Xml.Serialization.XmlEnumAttribute("030000")]
    Item030000,

    [System.Xml.Serialization.XmlEnumAttribute("030001")]
    Item030001,

    [System.Xml.Serialization.XmlEnumAttribute("030101")]
    Item030101,

    [System.Xml.Serialization.XmlEnumAttribute("030102")]
    Item030102,

    [System.Xml.Serialization.XmlEnumAttribute("030200")]
    Item030200,

    [System.Xml.Serialization.XmlEnumAttribute("030201")]
    Item030201,

    [System.Xml.Serialization.XmlEnumAttribute("030202")]
    Item030202,

    [System.Xml.Serialization.XmlEnumAttribute("030300")]
    Item030300,

    [System.Xml.Serialization.XmlEnumAttribute("030301")]
    Item030301,

    [System.Xml.Serialization.XmlEnumAttribute("030302")]
    Item030302,

    [System.Xml.Serialization.XmlEnumAttribute("030303")]
    Item030303,

    [System.Xml.Serialization.XmlEnumAttribute("030304")]
    Item030304,

    [System.Xml.Serialization.XmlEnumAttribute("030305")]
    Item030305,

    [System.Xml.Serialization.XmlEnumAttribute("030306")]
    Item030306,

    [System.Xml.Serialization.XmlEnumAttribute("030307")]
    Item030307,

    [System.Xml.Serialization.XmlEnumAttribute("030400")]
    Item030400,

    [System.Xml.Serialization.XmlEnumAttribute("030401")]
    Item030401,

    [System.Xml.Serialization.XmlEnumAttribute("030500")]
    Item030500,

    [System.Xml.Serialization.XmlEnumAttribute("030501")]
    Item030501,

    [System.Xml.Serialization.XmlEnumAttribute("030502")]
    Item030502,

    [System.Xml.Serialization.XmlEnumAttribute("040000")]
    Item040000,

    [System.Xml.Serialization.XmlEnumAttribute("040100")]
    Item040100,

    [System.Xml.Serialization.XmlEnumAttribute("040101")]
    Item040101,

    [System.Xml.Serialization.XmlEnumAttribute("040102")]
    Item040102,

    [System.Xml.Serialization.XmlEnumAttribute("040103")]
    Item040103,

    [System.Xml.Serialization.XmlEnumAttribute("040104")]
    Item040104,

    [System.Xml.Serialization.XmlEnumAttribute("040200")]
    Item040200,

    [System.Xml.Serialization.XmlEnumAttribute("040201")]
    Item040201,

    [System.Xml.Serialization.XmlEnumAttribute("040300")]
    Item040300,

    [System.Xml.Serialization.XmlEnumAttribute("040301")]
    Item040301,

    [System.Xml.Serialization.XmlEnumAttribute("040302")]
    Item040302,

    [System.Xml.Serialization.XmlEnumAttribute("040400")]
    Item040400,

    [System.Xml.Serialization.XmlEnumAttribute("040401")]
    Item040401,

    [System.Xml.Serialization.XmlEnumAttribute("040402")]
    Item040402,

    [System.Xml.Serialization.XmlEnumAttribute("040500")]
    Item040500,

    [System.Xml.Serialization.XmlEnumAttribute("040501")]
    Item040501,

    [System.Xml.Serialization.XmlEnumAttribute("040502")]
    Item040502,

    [System.Xml.Serialization.XmlEnumAttribute("040503")]
    Item040503,

    [System.Xml.Serialization.XmlEnumAttribute("040504")]
    Item040504,

    [System.Xml.Serialization.XmlEnumAttribute("040600")]
    Item040600,

    [System.Xml.Serialization.XmlEnumAttribute("040601")]
    Item040601,

    [System.Xml.Serialization.XmlEnumAttribute("040700")]
    Item040700,

    [System.Xml.Serialization.XmlEnumAttribute("040701")]
    Item040701,

    [System.Xml.Serialization.XmlEnumAttribute("040702")]
    Item040702,

    [System.Xml.Serialization.XmlEnumAttribute("040800")]
    Item040800,

    [System.Xml.Serialization.XmlEnumAttribute("040801")]
    Item040801,

    [System.Xml.Serialization.XmlEnumAttribute("040802")]
    Item040802,

    [System.Xml.Serialization.XmlEnumAttribute("040900")]
    Item040900,

    [System.Xml.Serialization.XmlEnumAttribute("040901")]
    Item040901,

    [System.Xml.Serialization.XmlEnumAttribute("041000")]
    Item041000,

    [System.Xml.Serialization.XmlEnumAttribute("041001")]
    Item041001,

    [System.Xml.Serialization.XmlEnumAttribute("041100")]
    Item041100,

    [System.Xml.Serialization.XmlEnumAttribute("041101")]
    Item041101,

    [System.Xml.Serialization.XmlEnumAttribute("041102")]
    Item041102,

    [System.Xml.Serialization.XmlEnumAttribute("050000")]
    Item050000,

    [System.Xml.Serialization.XmlEnumAttribute("050100")]
    Item050100,

    [System.Xml.Serialization.XmlEnumAttribute("050101")]
    Item050101,

    [System.Xml.Serialization.XmlEnumAttribute("050102")]
    Item050102,

    [System.Xml.Serialization.XmlEnumAttribute("050200")]
    Item050200,

    [System.Xml.Serialization.XmlEnumAttribute("050201")]
    Item050201,

    [System.Xml.Serialization.XmlEnumAttribute("050202")]
    Item050202,

    [System.Xml.Serialization.XmlEnumAttribute("050203")]
    Item050203,

    [System.Xml.Serialization.XmlEnumAttribute("050300")]
    Item050300,

    [System.Xml.Serialization.XmlEnumAttribute("050301")]
    Item050301,

    [System.Xml.Serialization.XmlEnumAttribute("050400")]
    Item050400,

    [System.Xml.Serialization.XmlEnumAttribute("050401")]
    Item050401,

    [System.Xml.Serialization.XmlEnumAttribute("050500")]
    Item050500,

    [System.Xml.Serialization.XmlEnumAttribute("050501")]
    Item050501,

    [System.Xml.Serialization.XmlEnumAttribute("050502")]
    Item050502,

    [System.Xml.Serialization.XmlEnumAttribute("060000")]
    Item060000,

    [System.Xml.Serialization.XmlEnumAttribute("060100")]
    Item060100,

    [System.Xml.Serialization.XmlEnumAttribute("060101")]
    Item060101,

    [System.Xml.Serialization.XmlEnumAttribute("060102")]
    Item060102,

    [System.Xml.Serialization.XmlEnumAttribute("060103")]
    Item060103,

    [System.Xml.Serialization.XmlEnumAttribute("060104")]
    Item060104,

    [System.Xml.Serialization.XmlEnumAttribute("060105")]
    Item060105,

    [System.Xml.Serialization.XmlEnumAttribute("060200")]
    Item060200,

    [System.Xml.Serialization.XmlEnumAttribute("060201")]
    Item060201,

    [System.Xml.Serialization.XmlEnumAttribute("060202")]
    Item060202,

    [System.Xml.Serialization.XmlEnumAttribute("060203")]
    Item060203,

    [System.Xml.Serialization.XmlEnumAttribute("060300")]
    Item060300,

    [System.Xml.Serialization.XmlEnumAttribute("060301")]
    Item060301,

    [System.Xml.Serialization.XmlEnumAttribute("060400")]
    Item060400,

    [System.Xml.Serialization.XmlEnumAttribute("060401")]
    Item060401,

    [System.Xml.Serialization.XmlEnumAttribute("060500")]
    Item060500,

    [System.Xml.Serialization.XmlEnumAttribute("060501")]
    Item060501,

    [System.Xml.Serialization.XmlEnumAttribute("060502")]
    Item060502,

    [System.Xml.Serialization.XmlEnumAttribute("060503")]
    Item060503,

    [System.Xml.Serialization.XmlEnumAttribute("060504")]
    Item060504,

    [System.Xml.Serialization.XmlEnumAttribute("060505")]
    Item060505,

    [System.Xml.Serialization.XmlEnumAttribute("060600")]
    Item060600,

    [System.Xml.Serialization.XmlEnumAttribute("060601")]
    Item060601,

    [System.Xml.Serialization.XmlEnumAttribute("060700")]
    Item060700,

    [System.Xml.Serialization.XmlEnumAttribute("060701")]
    Item060701,

    [System.Xml.Serialization.XmlEnumAttribute("060702")]
    Item060702,

    [System.Xml.Serialization.XmlEnumAttribute("070000")]
    Item070000,

    [System.Xml.Serialization.XmlEnumAttribute("070100")]
    Item070100,

    [System.Xml.Serialization.XmlEnumAttribute("070101")]
    Item070101,

    [System.Xml.Serialization.XmlEnumAttribute("070102")]
    Item070102,

    [System.Xml.Serialization.XmlEnumAttribute("070103")]
    Item070103,

    [System.Xml.Serialization.XmlEnumAttribute("070200")]
    Item070200,

    [System.Xml.Serialization.XmlEnumAttribute("070201")]
    Item070201,

    [System.Xml.Serialization.XmlEnumAttribute("070202")]
    Item070202,

    [System.Xml.Serialization.XmlEnumAttribute("070203")]
    Item070203,

    [System.Xml.Serialization.XmlEnumAttribute("070300")]
    Item070300,

    [System.Xml.Serialization.XmlEnumAttribute("070301")]
    Item070301,

    [System.Xml.Serialization.XmlEnumAttribute("070302")]
    Item070302,

    [System.Xml.Serialization.XmlEnumAttribute("070400")]
    Item070400,

    [System.Xml.Serialization.XmlEnumAttribute("070401")]
    Item070401,

    [System.Xml.Serialization.XmlEnumAttribute("070402")]
    Item070402,

    [System.Xml.Serialization.XmlEnumAttribute("070500")]
    Item070500,

    [System.Xml.Serialization.XmlEnumAttribute("070501")]
    Item070501,

    [System.Xml.Serialization.XmlEnumAttribute("070502")]
    Item070502,

    [System.Xml.Serialization.XmlEnumAttribute("070600")]
    Item070600,

    [System.Xml.Serialization.XmlEnumAttribute("070601")]
    Item070601,

    [System.Xml.Serialization.XmlEnumAttribute("080000")]
    Item080000,

    [System.Xml.Serialization.XmlEnumAttribute("080100")]
    Item080100,

    [System.Xml.Serialization.XmlEnumAttribute("080101")]
    Item080101,

    [System.Xml.Serialization.XmlEnumAttribute("080102")]
    Item080102,

    [System.Xml.Serialization.XmlEnumAttribute("080103")]
    Item080103,

    [System.Xml.Serialization.XmlEnumAttribute("080104")]
    Item080104,

    [System.Xml.Serialization.XmlEnumAttribute("080200")]
    Item080200,

    [System.Xml.Serialization.XmlEnumAttribute("080201")]
    Item080201,

    [System.Xml.Serialization.XmlEnumAttribute("080202")]
    Item080202,

    [System.Xml.Serialization.XmlEnumAttribute("080203")]
    Item080203,

    [System.Xml.Serialization.XmlEnumAttribute("090000")]
    Item090000,

    [System.Xml.Serialization.XmlEnumAttribute("090100")]
    Item090100,

    [System.Xml.Serialization.XmlEnumAttribute("090101")]
    Item090101,

    [System.Xml.Serialization.XmlEnumAttribute("090102")]
    Item090102,

    [System.Xml.Serialization.XmlEnumAttribute("090103")]
    Item090103,

    [System.Xml.Serialization.XmlEnumAttribute("090104")]
    Item090104,

    [System.Xml.Serialization.XmlEnumAttribute("090105")]
    Item090105,

    [System.Xml.Serialization.XmlEnumAttribute("090106")]
    Item090106,

    [System.Xml.Serialization.XmlEnumAttribute("090107")]
    Item090107,

    [System.Xml.Serialization.XmlEnumAttribute("090108")]
    Item090108,

    [System.Xml.Serialization.XmlEnumAttribute("090109")]
    Item090109,

    [System.Xml.Serialization.XmlEnumAttribute("090200")]
    Item090200,

    [System.Xml.Serialization.XmlEnumAttribute("090201")]
    Item090201,

    [System.Xml.Serialization.XmlEnumAttribute("090300")]
    Item090300,

    [System.Xml.Serialization.XmlEnumAttribute("090301")]
    Item090301,

    [System.Xml.Serialization.XmlEnumAttribute("090302")]
    Item090302,

    [System.Xml.Serialization.XmlEnumAttribute("090303")]
    Item090303,

    [System.Xml.Serialization.XmlEnumAttribute("090304")]
    Item090304,

    [System.Xml.Serialization.XmlEnumAttribute("090400")]
    Item090400,

    [System.Xml.Serialization.XmlEnumAttribute("090401")]
    Item090401,

    [System.Xml.Serialization.XmlEnumAttribute("100000")]
    Item100000,

    [System.Xml.Serialization.XmlEnumAttribute("100100")]
    Item100100,

    [System.Xml.Serialization.XmlEnumAttribute("100101")]
    Item100101,

    [System.Xml.Serialization.XmlEnumAttribute("100102")]
    Item100102,

    [System.Xml.Serialization.XmlEnumAttribute("100103")]
    Item100103,

    [System.Xml.Serialization.XmlEnumAttribute("100200")]
    Item100200,

    [System.Xml.Serialization.XmlEnumAttribute("100201")]
    Item100201,

    [System.Xml.Serialization.XmlEnumAttribute("100202")]
    Item100202,

    [System.Xml.Serialization.XmlEnumAttribute("100300")]
    Item100300,

    [System.Xml.Serialization.XmlEnumAttribute("100301")]
    Item100301,

    [System.Xml.Serialization.XmlEnumAttribute("100400")]
    Item100400,

    [System.Xml.Serialization.XmlEnumAttribute("100401")]
    Item100401,

    [System.Xml.Serialization.XmlEnumAttribute("100402")]
    Item100402,

    [System.Xml.Serialization.XmlEnumAttribute("100500")]
    Item100500,

    [System.Xml.Serialization.XmlEnumAttribute("100501")]
    Item100501,

    [System.Xml.Serialization.XmlEnumAttribute("100502")]
    Item100502,

    [System.Xml.Serialization.XmlEnumAttribute("100600")]
    Item100600,

    [System.Xml.Serialization.XmlEnumAttribute("100601")]
    Item100601,

    [System.Xml.Serialization.XmlEnumAttribute("100602")]
    Item100602,

    [System.Xml.Serialization.XmlEnumAttribute("110000")]
    Item110000,

    [System.Xml.Serialization.XmlEnumAttribute("110100")]
    Item110100,

    [System.Xml.Serialization.XmlEnumAttribute("110101")]
    Item110101,

    [System.Xml.Serialization.XmlEnumAttribute("110102")]
    Item110102,

    [System.Xml.Serialization.XmlEnumAttribute("110103")]
    Item110103,

    [System.Xml.Serialization.XmlEnumAttribute("110104")]
    Item110104,

    [System.Xml.Serialization.XmlEnumAttribute("110200")]
    Item110200,

    [System.Xml.Serialization.XmlEnumAttribute("110201")]
    Item110201,

    [System.Xml.Serialization.XmlEnumAttribute("110202")]
    Item110202,

    [System.Xml.Serialization.XmlEnumAttribute("110203")]
    Item110203,

    [System.Xml.Serialization.XmlEnumAttribute("120000")]
    Item120000,

    [System.Xml.Serialization.XmlEnumAttribute("120100")]
    Item120100,

    [System.Xml.Serialization.XmlEnumAttribute("120101")]
    Item120101,

    [System.Xml.Serialization.XmlEnumAttribute("120102")]
    Item120102,

    [System.Xml.Serialization.XmlEnumAttribute("120200")]
    Item120200,

    [System.Xml.Serialization.XmlEnumAttribute("120201")]
    Item120201,

    [System.Xml.Serialization.XmlEnumAttribute("120300")]
    Item120300,

    [System.Xml.Serialization.XmlEnumAttribute("120301")]
    Item120301,

    [System.Xml.Serialization.XmlEnumAttribute("120302")]
    Item120302,

    [System.Xml.Serialization.XmlEnumAttribute("130000")]
    Item130000,

    [System.Xml.Serialization.XmlEnumAttribute("130100")]
    Item130100,

    [System.Xml.Serialization.XmlEnumAttribute("130101")]
    Item130101,

    [System.Xml.Serialization.XmlEnumAttribute("130102")]
    Item130102,

    [System.Xml.Serialization.XmlEnumAttribute("130103")]
    Item130103,

    [System.Xml.Serialization.XmlEnumAttribute("130104")]
    Item130104,

    [System.Xml.Serialization.XmlEnumAttribute("130105")]
    Item130105,

    [System.Xml.Serialization.XmlEnumAttribute("130200")]
    Item130200,

    [System.Xml.Serialization.XmlEnumAttribute("130201")]
    Item130201,

    [System.Xml.Serialization.XmlEnumAttribute("130202")]
    Item130202,

    [System.Xml.Serialization.XmlEnumAttribute("130203")]
    Item130203,

    [System.Xml.Serialization.XmlEnumAttribute("130300")]
    Item130300,

    [System.Xml.Serialization.XmlEnumAttribute("130301")]
    Item130301,

    [System.Xml.Serialization.XmlEnumAttribute("130302")]
    Item130302,

    [System.Xml.Serialization.XmlEnumAttribute("130303")]
    Item130303,

    [System.Xml.Serialization.XmlEnumAttribute("130400")]
    Item130400,

    [System.Xml.Serialization.XmlEnumAttribute("130401")]
    Item130401,

    [System.Xml.Serialization.XmlEnumAttribute("130402")]
    Item130402,

    [System.Xml.Serialization.XmlEnumAttribute("140000")]
    Item140000,

    [System.Xml.Serialization.XmlEnumAttribute("140100")]
    Item140100,

    [System.Xml.Serialization.XmlEnumAttribute("140101")]
    Item140101,

    [System.Xml.Serialization.XmlEnumAttribute("140102")]
    Item140102,

    [System.Xml.Serialization.XmlEnumAttribute("140103")]
    Item140103,

    [System.Xml.Serialization.XmlEnumAttribute("140104")]
    Item140104,

    [System.Xml.Serialization.XmlEnumAttribute("140200")]
    Item140200,

    [System.Xml.Serialization.XmlEnumAttribute("140201")]
    Item140201,

    [System.Xml.Serialization.XmlEnumAttribute("140202")]
    Item140202,

    [System.Xml.Serialization.XmlEnumAttribute("140203")]
    Item140203,

    [System.Xml.Serialization.XmlEnumAttribute("140300")]
    Item140300,

    [System.Xml.Serialization.XmlEnumAttribute("140301")]
    Item140301,

    [System.Xml.Serialization.XmlEnumAttribute("140302")]
    Item140302,

    [System.Xml.Serialization.XmlEnumAttribute("140400")]
    Item140400,

    [System.Xml.Serialization.XmlEnumAttribute("140401")]
    Item140401,

    [System.Xml.Serialization.XmlEnumAttribute("150000")]
    Item150000,

    [System.Xml.Serialization.XmlEnumAttribute("150100")]
    Item150100,

    [System.Xml.Serialization.XmlEnumAttribute("150101")]
    Item150101,

    [System.Xml.Serialization.XmlEnumAttribute("150200")]
    Item150200,

    [System.Xml.Serialization.XmlEnumAttribute("150201")]
    Item150201,

    [System.Xml.Serialization.XmlEnumAttribute("150202")]
    Item150202,

    [System.Xml.Serialization.XmlEnumAttribute("150300")]
    Item150300,

    [System.Xml.Serialization.XmlEnumAttribute("150301")]
    Item150301,

    [System.Xml.Serialization.XmlEnumAttribute("150302")]
    Item150302,

    [System.Xml.Serialization.XmlEnumAttribute("150303")]
    Item150303,

    [System.Xml.Serialization.XmlEnumAttribute("150304")]
    Item150304,

    [System.Xml.Serialization.XmlEnumAttribute("150400")]
    Item150400,

    [System.Xml.Serialization.XmlEnumAttribute("150401")]
    Item150401,

    [System.Xml.Serialization.XmlEnumAttribute("150500")]
    Item150500,

    [System.Xml.Serialization.XmlEnumAttribute("150501")]
    Item150501,

    [System.Xml.Serialization.XmlEnumAttribute("150502")]
    Item150502,

    [System.Xml.Serialization.XmlEnumAttribute("150600")]
    Item150600,

    [System.Xml.Serialization.XmlEnumAttribute("150601")]
    Item150601,

    [System.Xml.Serialization.XmlEnumAttribute("160000")]
    Item160000,

    [System.Xml.Serialization.XmlEnumAttribute("160100")]
    Item160100,

    [System.Xml.Serialization.XmlEnumAttribute("160101")]
    Item160101,

    [System.Xml.Serialization.XmlEnumAttribute("160102")]
    Item160102,

    [System.Xml.Serialization.XmlEnumAttribute("160200")]
    Item160200,

    [System.Xml.Serialization.XmlEnumAttribute("160201")]
    Item160201,

    [System.Xml.Serialization.XmlEnumAttribute("160202")]
    Item160202,

    [System.Xml.Serialization.XmlEnumAttribute("170000")]
    Item170000,

    [System.Xml.Serialization.XmlEnumAttribute("170100")]
    Item170100,

    [System.Xml.Serialization.XmlEnumAttribute("170101")]
    Item170101,

    [System.Xml.Serialization.XmlEnumAttribute("170102")]
    Item170102,

    [System.Xml.Serialization.XmlEnumAttribute("170103")]
    Item170103,

    [System.Xml.Serialization.XmlEnumAttribute("170104")]
    Item170104,

    [System.Xml.Serialization.XmlEnumAttribute("170105")]
    Item170105,

    [System.Xml.Serialization.XmlEnumAttribute("170106")]
    Item170106,

    [System.Xml.Serialization.XmlEnumAttribute("170107")]
    Item170107,

    [System.Xml.Serialization.XmlEnumAttribute("170108")]
    Item170108,

    [System.Xml.Serialization.XmlEnumAttribute("170109")]
    Item170109,

    [System.Xml.Serialization.XmlEnumAttribute("170110")]
    Item170110,

    [System.Xml.Serialization.XmlEnumAttribute("170200")]
    Item170200,

    [System.Xml.Serialization.XmlEnumAttribute("170201")]
    Item170201,

    [System.Xml.Serialization.XmlEnumAttribute("170202")]
    Item170202,

    [System.Xml.Serialization.XmlEnumAttribute("170203")]
    Item170203,

    [System.Xml.Serialization.XmlEnumAttribute("170300")]
    Item170300,

    [System.Xml.Serialization.XmlEnumAttribute("170301")]
    Item170301,

    [System.Xml.Serialization.XmlEnumAttribute("180000")]
    Item180000,

    [System.Xml.Serialization.XmlEnumAttribute("180100")]
    Item180100,

    [System.Xml.Serialization.XmlEnumAttribute("180101")]
    Item180101,

    [System.Xml.Serialization.XmlEnumAttribute("180102")]
    Item180102,

    [System.Xml.Serialization.XmlEnumAttribute("180103")]
    Item180103,

    [System.Xml.Serialization.XmlEnumAttribute("180200")]
    Item180200,

    [System.Xml.Serialization.XmlEnumAttribute("180201")]
    Item180201,

    [System.Xml.Serialization.XmlEnumAttribute("180202")]
    Item180202,

    [System.Xml.Serialization.XmlEnumAttribute("180300")]
    Item180300,

    [System.Xml.Serialization.XmlEnumAttribute("180301")]
    Item180301,

    [System.Xml.Serialization.XmlEnumAttribute("180400")]
    Item180400,

    [System.Xml.Serialization.XmlEnumAttribute("180401")]
    Item180401,

    [System.Xml.Serialization.XmlEnumAttribute("180500")]
    Item180500,

    [System.Xml.Serialization.XmlEnumAttribute("180501")]
    Item180501,

    [System.Xml.Serialization.XmlEnumAttribute("180502")]
    Item180502,

    [System.Xml.Serialization.XmlEnumAttribute("180600")]
    Item180600,

    [System.Xml.Serialization.XmlEnumAttribute("180601")]
    Item180601,

    [System.Xml.Serialization.XmlEnumAttribute("180602")]
    Item180602,

    [System.Xml.Serialization.XmlEnumAttribute("180603")]
    Item180603,

    [System.Xml.Serialization.XmlEnumAttribute("180604")]
    Item180604,

    [System.Xml.Serialization.XmlEnumAttribute("180700")]
    Item180700,

    [System.Xml.Serialization.XmlEnumAttribute("180701")]
    Item180701,

    [System.Xml.Serialization.XmlEnumAttribute("180702")]
    Item180702,

    [System.Xml.Serialization.XmlEnumAttribute("180703")]
    Item180703,

    [System.Xml.Serialization.XmlEnumAttribute("180800")]
    Item180800,

    [System.Xml.Serialization.XmlEnumAttribute("180801")]
    Item180801,

    [System.Xml.Serialization.XmlEnumAttribute("180802")]
    Item180802,

    [System.Xml.Serialization.XmlEnumAttribute("180803")]
    Item180803,

    [System.Xml.Serialization.XmlEnumAttribute("180804")]
    Item180804,

    [System.Xml.Serialization.XmlEnumAttribute("180900")]
    Item180900,

    [System.Xml.Serialization.XmlEnumAttribute("180901")]
    Item180901,

    [System.Xml.Serialization.XmlEnumAttribute("190000")]
    Item190000,

    [System.Xml.Serialization.XmlEnumAttribute("190100")]
    Item190100,

    [System.Xml.Serialization.XmlEnumAttribute("190101")]
    Item190101,

    [System.Xml.Serialization.XmlEnumAttribute("190102")]
    Item190102,

    [System.Xml.Serialization.XmlEnumAttribute("190200")]
    Item190200,

    [System.Xml.Serialization.XmlEnumAttribute("190201")]
    Item190201,

    [System.Xml.Serialization.XmlEnumAttribute("190202")]
    Item190202,

    [System.Xml.Serialization.XmlEnumAttribute("190300")]
    Item190300,

    [System.Xml.Serialization.XmlEnumAttribute("190301")]
    Item190301,

    [System.Xml.Serialization.XmlEnumAttribute("200000")]
    Item200000,

    [System.Xml.Serialization.XmlEnumAttribute("200100")]
    Item200100,

    [System.Xml.Serialization.XmlEnumAttribute("200101")]
    Item200101,

    [System.Xml.Serialization.XmlEnumAttribute("200102")]
    Item200102,

    [System.Xml.Serialization.XmlEnumAttribute("200103")]
    Item200103,

    [System.Xml.Serialization.XmlEnumAttribute("200104")]
    Item200104,

    [System.Xml.Serialization.XmlEnumAttribute("200200")]
    Item200200,

    [System.Xml.Serialization.XmlEnumAttribute("200201")]
    Item200201,

    [System.Xml.Serialization.XmlEnumAttribute("200300")]
    Item200300,

    [System.Xml.Serialization.XmlEnumAttribute("200301")]
    Item200301,

    [System.Xml.Serialization.XmlEnumAttribute("210000")]
    Item210000,

    [System.Xml.Serialization.XmlEnumAttribute("210100")]
    Item210100,

    [System.Xml.Serialization.XmlEnumAttribute("210101")]
    Item210101,

    [System.Xml.Serialization.XmlEnumAttribute("210102")]
    Item210102,

    [System.Xml.Serialization.XmlEnumAttribute("210103")]
    Item210103,

    [System.Xml.Serialization.XmlEnumAttribute("210200")]
    Item210200,

    [System.Xml.Serialization.XmlEnumAttribute("210201")]
    Item210201,

    [System.Xml.Serialization.XmlEnumAttribute("210300")]
    Item210300,

    [System.Xml.Serialization.XmlEnumAttribute("210301")]
    Item210301,

    [System.Xml.Serialization.XmlEnumAttribute("210302")]
    Item210302,

    [System.Xml.Serialization.XmlEnumAttribute("210303")]
    Item210303,

    [System.Xml.Serialization.XmlEnumAttribute("210400")]
    Item210400,

    [System.Xml.Serialization.XmlEnumAttribute("210401")]
    Item210401,

    [System.Xml.Serialization.XmlEnumAttribute("210402")]
    Item210402,

    [System.Xml.Serialization.XmlEnumAttribute("210500")]
    Item210500,

    [System.Xml.Serialization.XmlEnumAttribute("210501")]
    Item210501,

    [System.Xml.Serialization.XmlEnumAttribute("210502")]
    Item210502,

    [System.Xml.Serialization.XmlEnumAttribute("210503")]
    Item210503,

    [System.Xml.Serialization.XmlEnumAttribute("210504")]
    Item210504,

    [System.Xml.Serialization.XmlEnumAttribute("210600")]
    Item210600,

    [System.Xml.Serialization.XmlEnumAttribute("210601")]
    Item210601,

    [System.Xml.Serialization.XmlEnumAttribute("210602")]
    Item210602,

    [System.Xml.Serialization.XmlEnumAttribute("210700")]
    Item210700,

    [System.Xml.Serialization.XmlEnumAttribute("210701")]
    Item210701,

    [System.Xml.Serialization.XmlEnumAttribute("210800")]
    Item210800,

    [System.Xml.Serialization.XmlEnumAttribute("210801")]
    Item210801,

    [System.Xml.Serialization.XmlEnumAttribute("220000")]
    Item220000,

    [System.Xml.Serialization.XmlEnumAttribute("220100")]
    Item220100,

    [System.Xml.Serialization.XmlEnumAttribute("220101")]
    Item220101,

    [System.Xml.Serialization.XmlEnumAttribute("220102")]
    Item220102,

    [System.Xml.Serialization.XmlEnumAttribute("220103")]
    Item220103,

    [System.Xml.Serialization.XmlEnumAttribute("220104")]
    Item220104,

    [System.Xml.Serialization.XmlEnumAttribute("220105")]
    Item220105,

    [System.Xml.Serialization.XmlEnumAttribute("220106")]
    Item220106,

    [System.Xml.Serialization.XmlEnumAttribute("220107")]
    Item220107,

    [System.Xml.Serialization.XmlEnumAttribute("220108")]
    Item220108,

    [System.Xml.Serialization.XmlEnumAttribute("220109")]
    Item220109,

    [System.Xml.Serialization.XmlEnumAttribute("220110")]
    Item220110,

    [System.Xml.Serialization.XmlEnumAttribute("220111")]
    Item220111,

    [System.Xml.Serialization.XmlEnumAttribute("220200")]
    Item220200,

    [System.Xml.Serialization.XmlEnumAttribute("220201")]
    Item220201,

    [System.Xml.Serialization.XmlEnumAttribute("220202")]
    Item220202,

    [System.Xml.Serialization.XmlEnumAttribute("220203")]
    Item220203,

    [System.Xml.Serialization.XmlEnumAttribute("220300")]
    Item220300,

    [System.Xml.Serialization.XmlEnumAttribute("220301")]
    Item220301,

    [System.Xml.Serialization.XmlEnumAttribute("220302")]
    Item220302,

    [System.Xml.Serialization.XmlEnumAttribute("220303")]
    Item220303,

    [System.Xml.Serialization.XmlEnumAttribute("220400")]
    Item220400,

    [System.Xml.Serialization.XmlEnumAttribute("220401")]
    Item220401,

    [System.Xml.Serialization.XmlEnumAttribute("220402")]
    Item220402,

    [System.Xml.Serialization.XmlEnumAttribute("220500")]
    Item220500,

    [System.Xml.Serialization.XmlEnumAttribute("220501")]
    Item220501,

    [System.Xml.Serialization.XmlEnumAttribute("220502")]
    Item220502,

    [System.Xml.Serialization.XmlEnumAttribute("220503")]
    Item220503,

    [System.Xml.Serialization.XmlEnumAttribute("220600")]
    Item220600,

    [System.Xml.Serialization.XmlEnumAttribute("220601")]
    Item220601,

    [System.Xml.Serialization.XmlEnumAttribute("220602")]
    Item220602,

    [System.Xml.Serialization.XmlEnumAttribute("230000")]
    Item230000,

    [System.Xml.Serialization.XmlEnumAttribute("230100")]
    Item230100,

    [System.Xml.Serialization.XmlEnumAttribute("230101")]
    Item230101,

    [System.Xml.Serialization.XmlEnumAttribute("230200")]
    Item230200,

    [System.Xml.Serialization.XmlEnumAttribute("230201")]
    Item230201,

    [System.Xml.Serialization.XmlEnumAttribute("230202")]
    Item230202,

    [System.Xml.Serialization.XmlEnumAttribute("230203")]
    Item230203,

    [System.Xml.Serialization.XmlEnumAttribute("230300")]
    Item230300,

    [System.Xml.Serialization.XmlEnumAttribute("230301")]
    Item230301,

    [System.Xml.Serialization.XmlEnumAttribute("230400")]
    Item230400,

    [System.Xml.Serialization.XmlEnumAttribute("230401")]
    Item230401,

    [System.Xml.Serialization.XmlEnumAttribute("230500")]
    Item230500,

    [System.Xml.Serialization.XmlEnumAttribute("230501")]
    Item230501,

    [System.Xml.Serialization.XmlEnumAttribute("230600")]
    Item230600,

    [System.Xml.Serialization.XmlEnumAttribute("230601")]
    Item230601,

    [System.Xml.Serialization.XmlEnumAttribute("240000")]
    Item240000,

    [System.Xml.Serialization.XmlEnumAttribute("240100")]
    Item240100,

    [System.Xml.Serialization.XmlEnumAttribute("240101")]
    Item240101,

    [System.Xml.Serialization.XmlEnumAttribute("240102")]
    Item240102,

    [System.Xml.Serialization.XmlEnumAttribute("240103")]
    Item240103,

    [System.Xml.Serialization.XmlEnumAttribute("240104")]
    Item240104,

    [System.Xml.Serialization.XmlEnumAttribute("240105")]
    Item240105,

    [System.Xml.Serialization.XmlEnumAttribute("240106")]
    Item240106,

    [System.Xml.Serialization.XmlEnumAttribute("240200")]
    Item240200,

    [System.Xml.Serialization.XmlEnumAttribute("240201")]
    Item240201,

    [System.Xml.Serialization.XmlEnumAttribute("240202")]
    Item240202,

    [System.Xml.Serialization.XmlEnumAttribute("240300")]
    Item240300,

    [System.Xml.Serialization.XmlEnumAttribute("240301")]
    Item240301,

    [System.Xml.Serialization.XmlEnumAttribute("240400")]
    Item240400,

    [System.Xml.Serialization.XmlEnumAttribute("240401")]
    Item240401,

    [System.Xml.Serialization.XmlEnumAttribute("240402")]
    Item240402,

    [System.Xml.Serialization.XmlEnumAttribute("240403")]
    Item240403,

    [System.Xml.Serialization.XmlEnumAttribute("240404")]
    Item240404,

    [System.Xml.Serialization.XmlEnumAttribute("250000")]
    Item250000,

    [System.Xml.Serialization.XmlEnumAttribute("250100")]
    Item250100,

    [System.Xml.Serialization.XmlEnumAttribute("250101")]
    Item250101,

    [System.Xml.Serialization.XmlEnumAttribute("250102")]
    Item250102,

    [System.Xml.Serialization.XmlEnumAttribute("250104")]
    Item250104,

    [System.Xml.Serialization.XmlEnumAttribute("250105")]
    Item250105,

    [System.Xml.Serialization.XmlEnumAttribute("250106")]
    Item250106,

    [System.Xml.Serialization.XmlEnumAttribute("250107")]
    Item250107,

    [System.Xml.Serialization.XmlEnumAttribute("250200")]
    Item250200,

    [System.Xml.Serialization.XmlEnumAttribute("250201")]
    Item250201,

    [System.Xml.Serialization.XmlEnumAttribute("250300")]
    Item250300,

    [System.Xml.Serialization.XmlEnumAttribute("250301")]
    Item250301,

    [System.Xml.Serialization.XmlEnumAttribute("250302")]
    Item250302,

    [System.Xml.Serialization.XmlEnumAttribute("250303")]
    Item250303,

    [System.Xml.Serialization.XmlEnumAttribute("250400")]
    Item250400,

    [System.Xml.Serialization.XmlEnumAttribute("250401")]
    Item250401,

    [System.Xml.Serialization.XmlEnumAttribute("250402")]
    Item250402,

    [System.Xml.Serialization.XmlEnumAttribute("250500")]
    Item250500,

    [System.Xml.Serialization.XmlEnumAttribute("250501")]
    Item250501,

    [System.Xml.Serialization.XmlEnumAttribute("250502")]
    Item250502,

    [System.Xml.Serialization.XmlEnumAttribute("250503")]
    Item250503,

    [System.Xml.Serialization.XmlEnumAttribute("250504")]
    Item250504,

    [System.Xml.Serialization.XmlEnumAttribute("250600")]
    Item250600,

    [System.Xml.Serialization.XmlEnumAttribute("250601")]
    Item250601,

    [System.Xml.Serialization.XmlEnumAttribute("250602")]
    Item250602,

    [System.Xml.Serialization.XmlEnumAttribute("250700")]
    Item250700,

    [System.Xml.Serialization.XmlEnumAttribute("250701")]
    Item250701,

    [System.Xml.Serialization.XmlEnumAttribute("250702")]
    Item250702,

    [System.Xml.Serialization.XmlEnumAttribute("250703")]
    Item250703,

    [System.Xml.Serialization.XmlEnumAttribute("250800")]
    Item250800,

    [System.Xml.Serialization.XmlEnumAttribute("250801")]
    Item250801,

    [System.Xml.Serialization.XmlEnumAttribute("250802")]
    Item250802,

    [System.Xml.Serialization.XmlEnumAttribute("250803")]
    Item250803,

    [System.Xml.Serialization.XmlEnumAttribute("250900")]
    Item250900,

    [System.Xml.Serialization.XmlEnumAttribute("250901")]
    Item250901,

    [System.Xml.Serialization.XmlEnumAttribute("251000")]
    Item251000,

    [System.Xml.Serialization.XmlEnumAttribute("251001")]
    Item251001,

    [System.Xml.Serialization.XmlEnumAttribute("260000")]
    Item260000,

    [System.Xml.Serialization.XmlEnumAttribute("260100")]
    Item260100,

    [System.Xml.Serialization.XmlEnumAttribute("260101")]
    Item260101,

    [System.Xml.Serialization.XmlEnumAttribute("260200")]
    Item260200,

    [System.Xml.Serialization.XmlEnumAttribute("260201")]
    Item260201,

    [System.Xml.Serialization.XmlEnumAttribute("260300")]
    Item260300,

    [System.Xml.Serialization.XmlEnumAttribute("260301")]
    Item260301,

    [System.Xml.Serialization.XmlEnumAttribute("270000")]
    Item270000,

    [System.Xml.Serialization.XmlEnumAttribute("270100")]
    Item270100,

    [System.Xml.Serialization.XmlEnumAttribute("270101")]
    Item270101,

    [System.Xml.Serialization.XmlEnumAttribute("270102")]
    Item270102,

    [System.Xml.Serialization.XmlEnumAttribute("270103")]
    Item270103,

    [System.Xml.Serialization.XmlEnumAttribute("270104")]
    Item270104,

    [System.Xml.Serialization.XmlEnumAttribute("270200")]
    Item270200,

    [System.Xml.Serialization.XmlEnumAttribute("270201")]
    Item270201,

    [System.Xml.Serialization.XmlEnumAttribute("270202")]
    Item270202,

    [System.Xml.Serialization.XmlEnumAttribute("270203")]
    Item270203,

    [System.Xml.Serialization.XmlEnumAttribute("270204")]
    Item270204,

    [System.Xml.Serialization.XmlEnumAttribute("270205")]
    Item270205,

    [System.Xml.Serialization.XmlEnumAttribute("270300")]
    Item270300,

    [System.Xml.Serialization.XmlEnumAttribute("270301")]
    Item270301,

    [System.Xml.Serialization.XmlEnumAttribute("270302")]
    Item270302,

    [System.Xml.Serialization.XmlEnumAttribute("270303")]
    Item270303,

    [System.Xml.Serialization.XmlEnumAttribute("270304")]
    Item270304,

    [System.Xml.Serialization.XmlEnumAttribute("280000")]
    Item280000,

    [System.Xml.Serialization.XmlEnumAttribute("280100")]
    Item280100,

    [System.Xml.Serialization.XmlEnumAttribute("280101")]
    Item280101,

    [System.Xml.Serialization.XmlEnumAttribute("280102")]
    Item280102,

    [System.Xml.Serialization.XmlEnumAttribute("280103")]
    Item280103,

    [System.Xml.Serialization.XmlEnumAttribute("280104")]
    Item280104,

    [System.Xml.Serialization.XmlEnumAttribute("280105")]
    Item280105,

    [System.Xml.Serialization.XmlEnumAttribute("280106")]
    Item280106,

    [System.Xml.Serialization.XmlEnumAttribute("280200")]
    Item280200,

    [System.Xml.Serialization.XmlEnumAttribute("280201")]
    Item280201,

    [System.Xml.Serialization.XmlEnumAttribute("280300")]
    Item280300,

    [System.Xml.Serialization.XmlEnumAttribute("280301")]
    Item280301,

    [System.Xml.Serialization.XmlEnumAttribute("280302")]
    Item280302,

    [System.Xml.Serialization.XmlEnumAttribute("280303")]
    Item280303,

    [System.Xml.Serialization.XmlEnumAttribute("290000")]
    Item290000,

    [System.Xml.Serialization.XmlEnumAttribute("290100")]
    Item290100,

    [System.Xml.Serialization.XmlEnumAttribute("290101")]
    Item290101,

    [System.Xml.Serialization.XmlEnumAttribute("290102")]
    Item290102,

    [System.Xml.Serialization.XmlEnumAttribute("290103")]
    Item290103,

    [System.Xml.Serialization.XmlEnumAttribute("290104")]
    Item290104,

    [System.Xml.Serialization.XmlEnumAttribute("290200")]
    Item290200,

    [System.Xml.Serialization.XmlEnumAttribute("290201")]
    Item290201,

    [System.Xml.Serialization.XmlEnumAttribute("290300")]
    Item290300,

    [System.Xml.Serialization.XmlEnumAttribute("290301")]
    Item290301,

    [System.Xml.Serialization.XmlEnumAttribute("290302")]
    Item290302,

    [System.Xml.Serialization.XmlEnumAttribute("290303")]
    Item290303,

    [System.Xml.Serialization.XmlEnumAttribute("290400")]
    Item290400,

    [System.Xml.Serialization.XmlEnumAttribute("290402")]
    Item290402,

    [System.Xml.Serialization.XmlEnumAttribute("290403")]
    Item290403,

    [System.Xml.Serialization.XmlEnumAttribute("290500")]
    Item290500,

    [System.Xml.Serialization.XmlEnumAttribute("290501")]
    Item290501,

    [System.Xml.Serialization.XmlEnumAttribute("300000")]
    Item300000,

    [System.Xml.Serialization.XmlEnumAttribute("300100")]
    Item300100,

    [System.Xml.Serialization.XmlEnumAttribute("300101")]
    Item300101,

    [System.Xml.Serialization.XmlEnumAttribute("300102")]
    Item300102,

    [System.Xml.Serialization.XmlEnumAttribute("300103")]
    Item300103,

    [System.Xml.Serialization.XmlEnumAttribute("300104")]
    Item300104,

    [System.Xml.Serialization.XmlEnumAttribute("300200")]
    Item300200,

    [System.Xml.Serialization.XmlEnumAttribute("300201")]
    Item300201,

    [System.Xml.Serialization.XmlEnumAttribute("300202")]
    Item300202,

    [System.Xml.Serialization.XmlEnumAttribute("300300")]
    Item300300,

    [System.Xml.Serialization.XmlEnumAttribute("300301")]
    Item300301,

    [System.Xml.Serialization.XmlEnumAttribute("310000")]
    Item310000,

    [System.Xml.Serialization.XmlEnumAttribute("310100")]
    Item310100,

    [System.Xml.Serialization.XmlEnumAttribute("310101")]
    Item310101,

    [System.Xml.Serialization.XmlEnumAttribute("310102")]
    Item310102,

    [System.Xml.Serialization.XmlEnumAttribute("310103")]
    Item310103,

    [System.Xml.Serialization.XmlEnumAttribute("310104")]
    Item310104,

    [System.Xml.Serialization.XmlEnumAttribute("310105")]
    Item310105,

    [System.Xml.Serialization.XmlEnumAttribute("310200")]
    Item310200,

    [System.Xml.Serialization.XmlEnumAttribute("310201")]
    Item310201,

    [System.Xml.Serialization.XmlEnumAttribute("310300")]
    Item310300,

    [System.Xml.Serialization.XmlEnumAttribute("310301")]
    Item310301,

    [System.Xml.Serialization.XmlEnumAttribute("320000")]
    Item320000,

    [System.Xml.Serialization.XmlEnumAttribute("320100")]
    Item320100,

    [System.Xml.Serialization.XmlEnumAttribute("320101")]
    Item320101,

    [System.Xml.Serialization.XmlEnumAttribute("320102")]
    Item320102,

    [System.Xml.Serialization.XmlEnumAttribute("320200")]
    Item320200,

    [System.Xml.Serialization.XmlEnumAttribute("320201")]
    Item320201,

    [System.Xml.Serialization.XmlEnumAttribute("320300")]
    Item320300,

    [System.Xml.Serialization.XmlEnumAttribute("320301")]
    Item320301,

    [System.Xml.Serialization.XmlEnumAttribute("320302")]
    Item320302,

    [System.Xml.Serialization.XmlEnumAttribute("320400")]
    Item320400,

    [System.Xml.Serialization.XmlEnumAttribute("320401")]
    Item320401,

    [System.Xml.Serialization.XmlEnumAttribute("320402")]
    Item320402,

    [System.Xml.Serialization.XmlEnumAttribute("320500")]
    Item320500,

    [System.Xml.Serialization.XmlEnumAttribute("320501")]
    Item320501,

    [System.Xml.Serialization.XmlEnumAttribute("320502")]
    Item320502,

    [System.Xml.Serialization.XmlEnumAttribute("320600")]
    Item320600,

    [System.Xml.Serialization.XmlEnumAttribute("320601")]
    Item320601,

    [System.Xml.Serialization.XmlEnumAttribute("320602")]
    Item320602,

    [System.Xml.Serialization.XmlEnumAttribute("320603")]
    Item320603,

    [System.Xml.Serialization.XmlEnumAttribute("320700")]
    Item320700,

    [System.Xml.Serialization.XmlEnumAttribute("320701")]
    Item320701,

    [System.Xml.Serialization.XmlEnumAttribute("320702")]
    Item320702,

    [System.Xml.Serialization.XmlEnumAttribute("320703")]
    Item320703,
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECF", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlRootAttribute("ECF", Namespace = "")]
public partial class ECF
{

    [System.Xml.Serialization.XmlElementAttribute("Encabezado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezado Encabezado { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private Collection<ECFDetallesItemsItem> _detallesItems;

    [System.Xml.Serialization.XmlArrayAttribute("DetallesItems", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public Collection<ECFDetallesItemsItem> DetallesItems
    {
        get
        {
            return this._detallesItems;
        }
        set
        {
            this._detallesItems = value;
        }
    }

    public ECF()
    {
        this._detallesItems = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItem>();
        this._subtotales = new System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal>();
        this._descuentosORecargos = new System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo>();
        this._paginacion = new System.Collections.ObjectModel.Collection<ECFPaginacionPagina>();
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal> _subtotales;

    [System.Xml.Serialization.XmlArrayAttribute("Subtotales", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Subtotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal> Subtotales
    {
        get
        {
            return this._subtotales;
        }
        private set
        {
            this._subtotales = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SubtotalesSpecified
    {
        get
        {
            return (this.Subtotales.Count != 0);
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo> _descuentosORecargos;

    [System.Xml.Serialization.XmlArrayAttribute("DescuentosORecargos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("DescuentoORecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo> DescuentosORecargos
    {
        get
        {
            return this._descuentosORecargos;
        }
        private set
        {
            this._descuentosORecargos = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool DescuentosORecargosSpecified
    {
        get
        {
            return (this.DescuentosORecargos.Count != 0);
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFPaginacionPagina> _paginacion;

    [System.Xml.Serialization.XmlArrayAttribute("Paginacion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFPaginacionPagina> Paginacion
    {
        get
        {
            return this._paginacion;
        }
        private set
        {
            this._paginacion = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PaginacionSpecified
    {
        get
        {
            return (this.Paginacion.Count != 0);
        }
    }

    [System.Xml.Serialization.XmlElementAttribute("InformacionReferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFInformacionReferencia InformacionReferencia { get; set; }

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(19)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0[1-9])-(1[0-2]|0[1-9])-((19|20)\\d{2}) (2[0-3]|[01]?[0-9]):([0-5" +
        "]?[0-9]):([0-5]?[0-9])")]
    [System.Xml.Serialization.XmlElementAttribute("FechaHoraFirma", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaHoraFirma { get; set; }

    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement Any { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezado", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezado
{

    [System.Xml.Serialization.XmlElementAttribute("Version", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public VersionType Version { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IdDoc", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoIdDoc IdDoc { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("Emisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoEmisor Emisor { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("Comprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoComprador Comprador { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("InformacionesAdicionales", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoInformacionesAdicionales InformacionesAdicionales { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("Transporte", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoTransporte Transporte { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("Totales", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoTotales Totales { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFEncabezadoOtraMoneda OtraMoneda { get; set; }

}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoIdDoc", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoIdDoc
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("^[0-9]{2}$")]
    [System.Xml.Serialization.XmlElementAttribute("TipoeCF", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TipoeCF { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(13)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(13)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("([a-z0-9A-Z]{13})")]
    [System.Xml.Serialization.XmlElementAttribute("eNCF", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ENCF { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaVencimientoSecuencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaVencimientoSecuencia { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicadorEnvioDiferido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorEnvioDiferidoType IndicadorEnvioDiferidoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndicadorEnvioDiferidoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<IndicadorEnvioDiferidoType> IndicadorEnvioDiferido
    {
        get
        {
            if (this.IndicadorEnvioDiferidoValueSpecified)
            {
                return this.IndicadorEnvioDiferidoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.IndicadorEnvioDiferidoValue = value.GetValueOrDefault();
            this.IndicadorEnvioDiferidoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicadorMontoGravado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorMontoGravadoType IndicadorMontoGravadoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndicadorMontoGravadoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<IndicadorMontoGravadoType> IndicadorMontoGravado
    {
        get
        {
            if (this.IndicadorMontoGravadoValueSpecified)
            {
                return this.IndicadorMontoGravadoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.IndicadorMontoGravadoValue = value.GetValueOrDefault();
            this.IndicadorMontoGravadoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0]{1}[1-6]{1}")]
    [System.Xml.Serialization.XmlElementAttribute("TipoIngresos", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TipoIngresos { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("TipoPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoPagoType TipoPago { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaLimitePago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaLimitePago { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[\\s\\d\\w]{1,15}")]
    [System.Xml.Serialization.XmlElementAttribute("TerminoPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TerminoPago { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago> _tablaFormasPago;

    [System.Xml.Serialization.XmlArrayAttribute("TablaFormasPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("FormaDePago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago> TablaFormasPago
    {
        get
        {
            return this._tablaFormasPago;
        }
        private set
        {
            this._tablaFormasPago = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaFormasPagoSpecified
    {
        get
        {
            return (this.TablaFormasPago.Count != 0);
        }
    }

    public ECFEncabezadoIdDoc()
    {
        this._tablaFormasPago = new System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago>();
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TipoCuentaPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoCuentaPagoType TipoCuentaPagoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TipoCuentaPagoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<TipoCuentaPagoType> TipoCuentaPago
    {
        get
        {
            if (this.TipoCuentaPagoValueSpecified)
            {
                return this.TipoCuentaPagoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TipoCuentaPagoValue = value.GetValueOrDefault();
            this.TipoCuentaPagoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(28)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroCuentaPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroCuentaPago { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(75)]
    [System.Xml.Serialization.XmlElementAttribute("BancoPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string BancoPago { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaDesde", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaDesde { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaHasta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaHasta { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalPaginas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public short TotalPaginasValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalPaginasValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<short> TotalPaginas
    {
        get
        {
            if (this.TotalPaginasValueSpecified)
            {
                return this.TotalPaginasValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalPaginasValue = value.GetValueOrDefault();
            this.TotalPaginasValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoIdDocTablaFormasPago", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoIdDocTablaFormasPago
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago> _formaDePago;

    [System.Xml.Serialization.XmlElementAttribute("FormaDePago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago> FormaDePago
    {
        get
        {
            return this._formaDePago;
        }
        private set
        {
            this._formaDePago = value;
        }
    }

    public ECFEncabezadoIdDocTablaFormasPago()
    {
        this._formaDePago = new System.Collections.ObjectModel.Collection<ECFEncabezadoIdDocTablaFormasPagoFormaDePago>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoIdDocTablaFormasPagoFormaDePago", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoIdDocTablaFormasPagoFormaDePago
{

    [System.Xml.Serialization.XmlElementAttribute("FormaPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public FormaPagoType FormaPago { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("MontoPago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoPago { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoEmisor", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoEmisor
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{11}|[0-9]{9}")]
    [System.Xml.Serialization.XmlElementAttribute("RNCEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RNCEmisor { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(150)]
    [System.Xml.Serialization.XmlElementAttribute("RazonSocialEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RazonSocialEmisor { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(150)]
    [System.Xml.Serialization.XmlElementAttribute("NombreComercial", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NombreComercial { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("Sucursal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Sucursal { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("DireccionEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DireccionEmisor { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Municipio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ProvinciaMunicipioType MunicipioValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MunicipioValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<ProvinciaMunicipioType> Municipio
    {
        get
        {
            if (this.MunicipioValueSpecified)
            {
                return this.MunicipioValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MunicipioValue = value.GetValueOrDefault();
            this.MunicipioValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Provincia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ProvinciaMunicipioType ProvinciaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ProvinciaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<ProvinciaMunicipioType> Provincia
    {
        get
        {
            if (this.ProvinciaValueSpecified)
            {
                return this.ProvinciaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ProvinciaValue = value.GetValueOrDefault();
            this.ProvinciaValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<string> _tablaTelefonoEmisor;

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(12)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\d{3}-\\d{3}-\\d{4}")]
    [System.Xml.Serialization.XmlArrayAttribute("TablaTelefonoEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("TelefonoEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<string> TablaTelefonoEmisor
    {
        get
        {
            return this._tablaTelefonoEmisor;
        }
        private set
        {
            this._tablaTelefonoEmisor = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaTelefonoEmisorSpecified
    {
        get
        {
            return (this.TablaTelefonoEmisor.Count != 0);
        }
    }

    public ECFEncabezadoEmisor()
    {
        this._tablaTelefonoEmisor = new System.Collections.ObjectModel.Collection<string>();
    }

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(80)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")]
    [System.Xml.Serialization.XmlElementAttribute("CorreoEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CorreoEmisor { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(50)]
    [System.Xml.Serialization.XmlElementAttribute("WebSite", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string WebSite { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("ActividadEconomica", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ActividadEconomica { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(60)]
    [System.Xml.Serialization.XmlElementAttribute("CodigoVendedor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CodigoVendedor { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroFacturaInterna", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroFacturaInterna { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,20}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroPedidoInterno", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal NumeroPedidoInternoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool NumeroPedidoInternoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> NumeroPedidoInterno
    {
        get
        {
            if (this.NumeroPedidoInternoValueSpecified)
            {
                return this.NumeroPedidoInternoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.NumeroPedidoInternoValue = value.GetValueOrDefault();
            this.NumeroPedidoInternoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("ZonaVenta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ZonaVenta { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("RutaVenta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RutaVenta { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(250)]
    [System.Xml.Serialization.XmlElementAttribute("InformacionAdicionalEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string InformacionAdicionalEmisor { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaEmision", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaEmision { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoEmisorTablaTelefonoEmisor", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoEmisorTablaTelefonoEmisor
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<string> _telefonoEmisor;

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(12)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\d{3}-\\d{3}-\\d{4}")]
    [System.Xml.Serialization.XmlElementAttribute("TelefonoEmisor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<string> TelefonoEmisor
    {
        get
        {
            return this._telefonoEmisor;
        }
        private set
        {
            this._telefonoEmisor = value;
        }
    }

    public ECFEncabezadoEmisorTablaTelefonoEmisor()
    {
        this._telefonoEmisor = new System.Collections.ObjectModel.Collection<string>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoComprador", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoComprador
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{11}|[0-9]{9}")]
    [System.Xml.Serialization.XmlElementAttribute("RNCComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RNCComprador { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(150)]
    [System.Xml.Serialization.XmlElementAttribute("RazonSocialComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RazonSocialComprador { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(80)]
    [System.Xml.Serialization.XmlElementAttribute("ContactoComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ContactoComprador { get; set; }

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(80)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*")]
    [System.Xml.Serialization.XmlElementAttribute("CorreoComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CorreoComprador { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("DireccionComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DireccionComprador { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MunicipioComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ProvinciaMunicipioType MunicipioCompradorValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MunicipioCompradorValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<ProvinciaMunicipioType> MunicipioComprador
    {
        get
        {
            if (this.MunicipioCompradorValueSpecified)
            {
                return this.MunicipioCompradorValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MunicipioCompradorValue = value.GetValueOrDefault();
            this.MunicipioCompradorValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProvinciaComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ProvinciaMunicipioType ProvinciaCompradorValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ProvinciaCompradorValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<ProvinciaMunicipioType> ProvinciaComprador
    {
        get
        {
            if (this.ProvinciaCompradorValueSpecified)
            {
                return this.ProvinciaCompradorValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ProvinciaCompradorValue = value.GetValueOrDefault();
            this.ProvinciaCompradorValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaEntrega", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaEntrega { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("ContactoEntrega", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ContactoEntrega { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("DireccionEntrega", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DireccionEntrega { get; set; }

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(12)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("\\d{3}-\\d{3}-\\d{4}")]
    [System.Xml.Serialization.XmlElementAttribute("TelefonoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TelefonoAdicional { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaOrdenCompra", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaOrdenCompra { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroOrdenCompra", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroOrdenCompra { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("CodigoInternoComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CodigoInternoComprador { get; set; }

    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("^[a-zA-ZñÑáéíóúÁÉÍÓÚ,\\s]*$")]
    [System.Xml.Serialization.XmlElementAttribute("ResponsablePago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ResponsablePago { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(150)]
    [System.Xml.Serialization.XmlElementAttribute("InformacionAdicionalComprador", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string InformacionAdicionalComprador { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoInformacionesAdicionales", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoInformacionesAdicionales
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaEmbarque", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaEmbarque { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(25)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroEmbarque", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroEmbarque { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(100)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroContenedor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroContenedor { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,20}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroReferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal NumeroReferenciaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool NumeroReferenciaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> NumeroReferencia
    {
        get
        {
            if (this.NumeroReferenciaValueSpecified)
            {
                return this.NumeroReferenciaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.NumeroReferenciaValue = value.GetValueOrDefault();
            this.NumeroReferenciaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PesoBruto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal PesoBrutoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool PesoBrutoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> PesoBruto
    {
        get
        {
            if (this.PesoBrutoValueSpecified)
            {
                return this.PesoBrutoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.PesoBrutoValue = value.GetValueOrDefault();
            this.PesoBrutoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PesoNeto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal PesoNetoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool PesoNetoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> PesoNeto
    {
        get
        {
            if (this.PesoNetoValueSpecified)
            {
                return this.PesoNetoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.PesoNetoValue = value.GetValueOrDefault();
            this.PesoNetoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadPesoBruto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadPesoBrutoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadPesoBrutoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadPesoBruto
    {
        get
        {
            if (this.UnidadPesoBrutoValueSpecified)
            {
                return this.UnidadPesoBrutoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadPesoBrutoValue = value.GetValueOrDefault();
            this.UnidadPesoBrutoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadPesoNeto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadPesoNetoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadPesoNetoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadPesoNeto
    {
        get
        {
            if (this.UnidadPesoNetoValueSpecified)
            {
                return this.UnidadPesoNetoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadPesoNetoValue = value.GetValueOrDefault();
            this.UnidadPesoNetoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CantidadBulto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal CantidadBultoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool CantidadBultoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> CantidadBulto
    {
        get
        {
            if (this.CantidadBultoValueSpecified)
            {
                return this.CantidadBultoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.CantidadBultoValue = value.GetValueOrDefault();
            this.CantidadBultoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadBulto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadBultoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadBultoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadBulto
    {
        get
        {
            if (this.UnidadBultoValueSpecified)
            {
                return this.UnidadBultoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadBultoValue = value.GetValueOrDefault();
            this.UnidadBultoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VolumenBulto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal VolumenBultoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool VolumenBultoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> VolumenBulto
    {
        get
        {
            if (this.VolumenBultoValueSpecified)
            {
                return this.VolumenBultoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.VolumenBultoValue = value.GetValueOrDefault();
            this.VolumenBultoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadVolumen", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadVolumenValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadVolumenValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadVolumen
    {
        get
        {
            if (this.UnidadVolumenValueSpecified)
            {
                return this.UnidadVolumenValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadVolumenValue = value.GetValueOrDefault();
            this.UnidadVolumenValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoTransporte", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoTransporte
{

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("Conductor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Conductor { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,20}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentoTransporte", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal DocumentoTransporteValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool DocumentoTransporteValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> DocumentoTransporte
    {
        get
        {
            if (this.DocumentoTransporteValueSpecified)
            {
                return this.DocumentoTransporteValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.DocumentoTransporteValue = value.GetValueOrDefault();
            this.DocumentoTransporteValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(10)]
    [System.Xml.Serialization.XmlElementAttribute("Ficha", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Ficha { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(7)]
    [System.Xml.Serialization.XmlElementAttribute("Placa", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Placa { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("RutaTransporte", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RutaTransporte { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("ZonaTransporte", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string ZonaTransporte { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(20)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroAlbaran", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NumeroAlbaran { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoTotales", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoTotales
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravadoTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoTotalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravadoTotalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravadoTotal
    {
        get
        {
            if (this.MontoGravadoTotalValueSpecified)
            {
                return this.MontoGravadoTotalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravadoTotalValue = value.GetValueOrDefault();
            this.MontoGravadoTotalValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravadoI1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI1Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravadoI1ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravadoI1
    {
        get
        {
            if (this.MontoGravadoI1ValueSpecified)
            {
                return this.MontoGravadoI1Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravadoI1Value = value.GetValueOrDefault();
            this.MontoGravadoI1ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravadoI2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI2Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravadoI2ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravadoI2
    {
        get
        {
            if (this.MontoGravadoI2ValueSpecified)
            {
                return this.MontoGravadoI2Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravadoI2Value = value.GetValueOrDefault();
            this.MontoGravadoI2ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravadoI3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoI3Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravadoI3ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravadoI3
    {
        get
        {
            if (this.MontoGravadoI3ValueSpecified)
            {
                return this.MontoGravadoI3Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravadoI3Value = value.GetValueOrDefault();
            this.MontoGravadoI3ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoExento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoExentoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoExentoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoExento
    {
        get
        {
            if (this.MontoExentoValueSpecified)
            {
                return this.MontoExentoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoExentoValue = value.GetValueOrDefault();
            this.MontoExentoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ITBIS1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte ITBIS1Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ITBIS1ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> ITBIS1
    {
        get
        {
            if (this.ITBIS1ValueSpecified)
            {
                return this.ITBIS1Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ITBIS1Value = value.GetValueOrDefault();
            this.ITBIS1ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ITBIS2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte ITBIS2Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ITBIS2ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> ITBIS2
    {
        get
        {
            if (this.ITBIS2ValueSpecified)
            {
                return this.ITBIS2Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ITBIS2Value = value.GetValueOrDefault();
            this.ITBIS2ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ITBIS3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte ITBIS3Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ITBIS3ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> ITBIS3
    {
        get
        {
            if (this.ITBIS3ValueSpecified)
            {
                return this.ITBIS3Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ITBIS3Value = value.GetValueOrDefault();
            this.ITBIS3ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBISValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBISValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS
    {
        get
        {
            if (this.TotalITBISValueSpecified)
            {
                return this.TotalITBISValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBISValue = value.GetValueOrDefault();
            this.TotalITBISValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS1Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS1ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS1
    {
        get
        {
            if (this.TotalITBIS1ValueSpecified)
            {
                return this.TotalITBIS1Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS1Value = value.GetValueOrDefault();
            this.TotalITBIS1ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS2Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS2ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS2
    {
        get
        {
            if (this.TotalITBIS2ValueSpecified)
            {
                return this.TotalITBIS2Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS2Value = value.GetValueOrDefault();
            this.TotalITBIS2ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS3Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS3ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS3
    {
        get
        {
            if (this.TotalITBIS3ValueSpecified)
            {
                return this.TotalITBIS3Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS3Value = value.GetValueOrDefault();
            this.TotalITBIS3ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoAdicionalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoAdicionalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoAdicional
    {
        get
        {
            if (this.MontoImpuestoAdicionalValueSpecified)
            {
                return this.MontoImpuestoAdicionalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoAdicionalValue = value.GetValueOrDefault();
            this.MontoImpuestoAdicionalValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional> _impuestosAdicionales;

    [System.Xml.Serialization.XmlArrayAttribute("ImpuestosAdicionales", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional> ImpuestosAdicionales
    {
        get
        {
            return this._impuestosAdicionales;
        }
        private set
        {
            this._impuestosAdicionales = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImpuestosAdicionalesSpecified
    {
        get
        {
            return (this.ImpuestosAdicionales.Count != 0);
        }
    }

    public ECFEncabezadoTotales()
    {
        this._impuestosAdicionales = new System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional>();
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("MontoTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoTotal { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoNoFacturable", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoNoFacturableValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoNoFacturableValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoNoFacturable
    {
        get
        {
            if (this.MontoNoFacturableValueSpecified)
            {
                return this.MontoNoFacturableValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoNoFacturableValue = value.GetValueOrDefault();
            this.MontoNoFacturableValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoPeriodo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoPeriodoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoPeriodoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoPeriodo
    {
        get
        {
            if (this.MontoPeriodoValueSpecified)
            {
                return this.MontoPeriodoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoPeriodoValue = value.GetValueOrDefault();
            this.MontoPeriodoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SaldoAnterior", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SaldoAnteriorValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SaldoAnteriorValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SaldoAnterior
    {
        get
        {
            if (this.SaldoAnteriorValueSpecified)
            {
                return this.SaldoAnteriorValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SaldoAnteriorValue = value.GetValueOrDefault();
            this.SaldoAnteriorValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoAvancePago", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoAvancePagoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoAvancePagoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoAvancePago
    {
        get
        {
            if (this.MontoAvancePagoValueSpecified)
            {
                return this.MontoAvancePagoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoAvancePagoValue = value.GetValueOrDefault();
            this.MontoAvancePagoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[+-]?[0-9]{1,16}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValorPagar", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal ValorPagarValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ValorPagarValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> ValorPagar
    {
        get
        {
            if (this.ValorPagarValueSpecified)
            {
                return this.ValorPagarValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ValorPagarValue = value.GetValueOrDefault();
            this.ValorPagarValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBISRetenido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBISRetenidoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBISRetenidoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBISRetenido
    {
        get
        {
            if (this.TotalITBISRetenidoValueSpecified)
            {
                return this.TotalITBISRetenidoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBISRetenidoValue = value.GetValueOrDefault();
            this.TotalITBISRetenidoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalISRRetencion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalISRRetencionValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalISRRetencionValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalISRRetencion
    {
        get
        {
            if (this.TotalISRRetencionValueSpecified)
            {
                return this.TotalISRRetencionValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalISRRetencionValue = value.GetValueOrDefault();
            this.TotalISRRetencionValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBISPercepcion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBISPercepcionValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBISPercepcionValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBISPercepcion
    {
        get
        {
            if (this.TotalITBISPercepcionValueSpecified)
            {
                return this.TotalITBISPercepcionValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBISPercepcionValue = value.GetValueOrDefault();
            this.TotalITBISPercepcionValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalISRPercepcion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalISRPercepcionValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalISRPercepcionValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalISRPercepcion
    {
        get
        {
            if (this.TotalISRPercepcionValueSpecified)
            {
                return this.TotalISRPercepcionValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalISRPercepcionValue = value.GetValueOrDefault();
            this.TotalISRPercepcionValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoTotalesImpuestosAdicionales", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoTotalesImpuestosAdicionales
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional> _impuestoAdicional;

    [System.Xml.Serialization.XmlElementAttribute("ImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional> ImpuestoAdicional
    {
        get
        {
            return this._impuestoAdicional;
        }
        private set
        {
            this._impuestoAdicional = value;
        }
    }

    public ECFEncabezadoTotalesImpuestosAdicionales()
    {
        this._impuestoAdicional = new System.Collections.ObjectModel.Collection<ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoTotalesImpuestosAdicionalesImpuestoAdicional
{

    [System.Xml.Serialization.XmlElementAttribute("TipoImpuesto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CodificacionTipoImpuestosType TipoImpuesto { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("TasaImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TasaImpuestoAdicional { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoSelectivoConsumoEspecifico", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoSelectivoConsumoEspecificoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoSelectivoConsumoEspecificoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoSelectivoConsumoEspecifico
    {
        get
        {
            if (this.MontoImpuestoSelectivoConsumoEspecificoValueSpecified)
            {
                return this.MontoImpuestoSelectivoConsumoEspecificoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoSelectivoConsumoEspecificoValue = value.GetValueOrDefault();
            this.MontoImpuestoSelectivoConsumoEspecificoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoSelectivoConsumoAdvalorem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoSelectivoConsumoAdvaloremValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoSelectivoConsumoAdvaloremValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoSelectivoConsumoAdvalorem
    {
        get
        {
            if (this.MontoImpuestoSelectivoConsumoAdvaloremValueSpecified)
            {
                return this.MontoImpuestoSelectivoConsumoAdvaloremValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoSelectivoConsumoAdvaloremValue = value.GetValueOrDefault();
            this.MontoImpuestoSelectivoConsumoAdvaloremValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtrosImpuestosAdicionales", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal OtrosImpuestosAdicionalesValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool OtrosImpuestosAdicionalesValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> OtrosImpuestosAdicionales
    {
        get
        {
            if (this.OtrosImpuestosAdicionalesValueSpecified)
            {
                return this.OtrosImpuestosAdicionalesValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.OtrosImpuestosAdicionalesValue = value.GetValueOrDefault();
            this.OtrosImpuestosAdicionalesValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoOtraMoneda", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoOtraMoneda
{

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TipoMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoMonedaType TipoMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TipoMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<TipoMonedaType> TipoMoneda
    {
        get
        {
            if (this.TipoMonedaValueSpecified)
            {
                return this.TipoMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TipoMonedaValue = value.GetValueOrDefault();
            this.TipoMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,4})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TipoCambio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TipoCambioValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TipoCambioValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TipoCambio
    {
        get
        {
            if (this.TipoCambioValueSpecified)
            {
                return this.TipoCambioValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TipoCambioValue = value.GetValueOrDefault();
            this.TipoCambioValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravadoTotalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravadoTotalOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravadoTotalOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravadoTotalOtraMoneda
    {
        get
        {
            if (this.MontoGravadoTotalOtraMonedaValueSpecified)
            {
                return this.MontoGravadoTotalOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravadoTotalOtraMonedaValue = value.GetValueOrDefault();
            this.MontoGravadoTotalOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravado1OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravado1OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravado1OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravado1OtraMoneda
    {
        get
        {
            if (this.MontoGravado1OtraMonedaValueSpecified)
            {
                return this.MontoGravado1OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravado1OtraMonedaValue = value.GetValueOrDefault();
            this.MontoGravado1OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravado2OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravado2OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravado2OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravado2OtraMoneda
    {
        get
        {
            if (this.MontoGravado2OtraMonedaValueSpecified)
            {
                return this.MontoGravado2OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravado2OtraMonedaValue = value.GetValueOrDefault();
            this.MontoGravado2OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoGravado3OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoGravado3OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoGravado3OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoGravado3OtraMoneda
    {
        get
        {
            if (this.MontoGravado3OtraMonedaValueSpecified)
            {
                return this.MontoGravado3OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoGravado3OtraMonedaValue = value.GetValueOrDefault();
            this.MontoGravado3OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoExentoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoExentoOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoExentoOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoExentoOtraMoneda
    {
        get
        {
            if (this.MontoExentoOtraMonedaValueSpecified)
            {
                return this.MontoExentoOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoExentoOtraMonedaValue = value.GetValueOrDefault();
            this.MontoExentoOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBISOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBISOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBISOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBISOtraMoneda
    {
        get
        {
            if (this.TotalITBISOtraMonedaValueSpecified)
            {
                return this.TotalITBISOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBISOtraMonedaValue = value.GetValueOrDefault();
            this.TotalITBISOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS1OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS1OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS1OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS1OtraMoneda
    {
        get
        {
            if (this.TotalITBIS1OtraMonedaValueSpecified)
            {
                return this.TotalITBIS1OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS1OtraMonedaValue = value.GetValueOrDefault();
            this.TotalITBIS1OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS2OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS2OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS2OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS2OtraMoneda
    {
        get
        {
            if (this.TotalITBIS2OtraMonedaValueSpecified)
            {
                return this.TotalITBIS2OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS2OtraMonedaValue = value.GetValueOrDefault();
            this.TotalITBIS2OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalITBIS3OtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TotalITBIS3OtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TotalITBIS3OtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> TotalITBIS3OtraMoneda
    {
        get
        {
            if (this.TotalITBIS3OtraMonedaValueSpecified)
            {
                return this.TotalITBIS3OtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TotalITBIS3OtraMonedaValue = value.GetValueOrDefault();
            this.TotalITBIS3OtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoAdicionalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoAdicionalOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoAdicionalOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoAdicionalOtraMoneda
    {
        get
        {
            if (this.MontoImpuestoAdicionalOtraMonedaValueSpecified)
            {
                return this.MontoImpuestoAdicionalOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoAdicionalOtraMonedaValue = value.GetValueOrDefault();
            this.MontoImpuestoAdicionalOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda> _impuestosAdicionalesOtraMoneda;

    [System.Xml.Serialization.XmlArrayAttribute("ImpuestosAdicionalesOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ImpuestoAdicionalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda> ImpuestosAdicionalesOtraMoneda
    {
        get
        {
            return this._impuestosAdicionalesOtraMoneda;
        }
        private set
        {
            this._impuestosAdicionalesOtraMoneda = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ImpuestosAdicionalesOtraMonedaSpecified
    {
        get
        {
            return (this.ImpuestosAdicionalesOtraMoneda.Count != 0);
        }
    }

    public ECFEncabezadoOtraMoneda()
    {
        this._impuestosAdicionalesOtraMoneda = new System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda>();
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoTotalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoTotalOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoTotalOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoTotalOtraMoneda
    {
        get
        {
            if (this.MontoTotalOtraMonedaValueSpecified)
            {
                return this.MontoTotalOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoTotalOtraMonedaValue = value.GetValueOrDefault();
            this.MontoTotalOtraMonedaValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMoneda", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMoneda
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda> _impuestoAdicionalOtraMoneda;

    [System.Xml.Serialization.XmlElementAttribute("ImpuestoAdicionalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda> ImpuestoAdicionalOtraMoneda
    {
        get
        {
            return this._impuestoAdicionalOtraMoneda;
        }
        private set
        {
            this._impuestoAdicionalOtraMoneda = value;
        }
    }

    public ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMoneda()
    {
        this._impuestoAdicionalOtraMoneda = new System.Collections.ObjectModel.Collection<ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFEncabezadoOtraMonedaImpuestosAdicionalesOtraMonedaImpuestoAdicionalOtraMoneda
{

    [System.Xml.Serialization.XmlElementAttribute("TipoImpuestoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CodificacionTipoImpuestosType TipoImpuestoOtraMoneda { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("TasaImpuestoAdicionalOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal TasaImpuestoAdicionalOtraMoneda { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoSelectivoConsumoEspecificoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoSelectivoConsumoEspecificoOtraMoneda
    {
        get
        {
            if (this.MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValueSpecified)
            {
                return this.MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValue = value.GetValueOrDefault();
            this.MontoImpuestoSelectivoConsumoEspecificoOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoImpuestoSelectivoConsumoAdvaloremOtraMoneda
    {
        get
        {
            if (this.MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValueSpecified)
            {
                return this.MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValue = value.GetValueOrDefault();
            this.MontoImpuestoSelectivoConsumoAdvaloremOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtrosImpuestosAdicionalesOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal OtrosImpuestosAdicionalesOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool OtrosImpuestosAdicionalesOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> OtrosImpuestosAdicionalesOtraMoneda
    {
        get
        {
            if (this.OtrosImpuestosAdicionalesOtraMonedaValueSpecified)
            {
                return this.OtrosImpuestosAdicionalesOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.OtrosImpuestosAdicionalesOtraMonedaValue = value.GetValueOrDefault();
            this.OtrosImpuestosAdicionalesOtraMonedaValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItems", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItems
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItem> _item;

    [System.Xml.Serialization.XmlElementAttribute("Item", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItem> Item
    {
        get
        {
            return this._item;
        }
        private set
        {
            this._item = value;
        }
    }

    public ECFDetallesItems()
    {
        this._item = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItem>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItem", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItem
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{0,3}")]
    [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "1", "100")]
    [System.Xml.Serialization.XmlElementAttribute("NumeroLinea", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public short NumeroLinea { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem> _tablaCodigosItem;

    [System.Xml.Serialization.XmlArrayAttribute("TablaCodigosItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("CodigosItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem> TablaCodigosItem
    {
        get
        {
            return this._tablaCodigosItem;
        }
        private set
        {
            this._tablaCodigosItem = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaCodigosItemSpecified
    {
        get
        {
            return (this.TablaCodigosItem.Count != 0);
        }
    }

    public ECFDetallesItemsItem()
    {
        this._tablaCodigosItem = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem>();
        this._tablaSubcantidad = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem>();
        this._tablaSubDescuento = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento>();
        this._tablaSubRecargo = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo>();
        this._tablaImpuestoAdicional = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional>();
    }

    [System.Xml.Serialization.XmlElementAttribute("IndicadorFacturacion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public int? IndicadorFacturacion { get; set; }

    

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(80)]
    [System.Xml.Serialization.XmlElementAttribute("NombreItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NombreItem { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("IndicadorBienoServicio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorBienoServicioType IndicadorBienoServicio { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(1000)]
    [System.Xml.Serialization.XmlElementAttribute("DescripcionItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionItem { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("CantidadItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal CantidadItem { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadMedida", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadMedidaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadMedidaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadMedida
    {
        get
        {
            if (this.UnidadMedidaValueSpecified)
            {
                return this.UnidadMedidaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadMedidaValue = value.GetValueOrDefault();
            this.UnidadMedidaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CantidadReferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal CantidadReferenciaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool CantidadReferenciaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> CantidadReferencia
    {
        get
        {
            if (this.CantidadReferenciaValueSpecified)
            {
                return this.CantidadReferenciaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.CantidadReferenciaValue = value.GetValueOrDefault();
            this.CantidadReferenciaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnidadReferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType UnidadReferenciaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool UnidadReferenciaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> UnidadReferencia
    {
        get
        {
            if (this.UnidadReferenciaValueSpecified)
            {
                return this.UnidadReferenciaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.UnidadReferenciaValue = value.GetValueOrDefault();
            this.UnidadReferenciaValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem> _tablaSubcantidad;

    [System.Xml.Serialization.XmlArrayAttribute("TablaSubcantidad", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SubcantidadItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem> TablaSubcantidad
    {
        get
        {
            return this._tablaSubcantidad;
        }
        private set
        {
            this._tablaSubcantidad = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaSubcantidadSpecified
    {
        get
        {
            return (this.TablaSubcantidad.Count != 0);
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GradosAlcohol", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal GradosAlcoholValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool GradosAlcoholValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> GradosAlcohol
    {
        get
        {
            if (this.GradosAlcoholValueSpecified)
            {
                return this.GradosAlcoholValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.GradosAlcoholValue = value.GetValueOrDefault();
            this.GradosAlcoholValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrecioUnitarioReferencia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal PrecioUnitarioReferenciaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool PrecioUnitarioReferenciaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> PrecioUnitarioReferencia
    {
        get
        {
            if (this.PrecioUnitarioReferenciaValueSpecified)
            {
                return this.PrecioUnitarioReferenciaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.PrecioUnitarioReferenciaValue = value.GetValueOrDefault();
            this.PrecioUnitarioReferenciaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaElaboracion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaElaboracion { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaVencimientoItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaVencimientoItem { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(\\d{1,16})(\\.\\d{1,4})?")]
    [System.Xml.Serialization.XmlElementAttribute("PrecioUnitarioItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal PrecioUnitarioItem { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DescuentoMonto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal DescuentoMontoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool DescuentoMontoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> DescuentoMonto
    {
        get
        {
            if (this.DescuentoMontoValueSpecified)
            {
                return this.DescuentoMontoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.DescuentoMontoValue = value.GetValueOrDefault();
            this.DescuentoMontoValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento> _tablaSubDescuento;

    [System.Xml.Serialization.XmlArrayAttribute("TablaSubDescuento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SubDescuento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento> TablaSubDescuento
    {
        get
        {
            return this._tablaSubDescuento;
        }
        private set
        {
            this._tablaSubDescuento = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaSubDescuentoSpecified
    {
        get
        {
            return (this.TablaSubDescuento.Count != 0);
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RecargoMonto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal RecargoMontoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool RecargoMontoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> RecargoMonto
    {
        get
        {
            if (this.RecargoMontoValueSpecified)
            {
                return this.RecargoMontoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.RecargoMontoValue = value.GetValueOrDefault();
            this.RecargoMontoValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo> _tablaSubRecargo;

    [System.Xml.Serialization.XmlArrayAttribute("TablaSubRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SubRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo> TablaSubRecargo
    {
        get
        {
            return this._tablaSubRecargo;
        }
        private set
        {
            this._tablaSubRecargo = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaSubRecargoSpecified
    {
        get
        {
            return (this.TablaSubRecargo.Count != 0);
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> _tablaImpuestoAdicional;

    [System.Xml.Serialization.XmlArrayAttribute("TablaImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> TablaImpuestoAdicional
    {
        get
        {
            return this._tablaImpuestoAdicional;
        }
        private set
        {
            this._tablaImpuestoAdicional = value;
        }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TablaImpuestoAdicionalSpecified
    {
        get
        {
            return (this.TablaImpuestoAdicional.Count != 0);
        }
    }

    [System.Xml.Serialization.XmlElementAttribute("OtraMonedaDetalle", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFDetallesItemsItemOtraMonedaDetalle OtraMonedaDetalle2 { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.Xml.Serialization.XmlElementAttribute("MontoItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoItem { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaCodigosItem", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaCodigosItem
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem> _codigosItem;

    [System.Xml.Serialization.XmlElementAttribute("CodigosItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem> CodigosItem
    {
        get
        {
            return this._codigosItem;
        }
        private set
        {
            this._codigosItem = value;
        }
    }

    public ECFDetallesItemsItemTablaCodigosItem()
    {
        this._codigosItem = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaCodigosItemCodigosItem>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaCodigosItemCodigosItem", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaCodigosItemCodigosItem
{

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(14)]
    [System.Xml.Serialization.XmlElementAttribute("TipoCodigo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TipoCodigo { get; set; }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(35)]
    [System.Xml.Serialization.XmlElementAttribute("CodigoItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CodigoItem { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemRetencion", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemRetencion
{

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicadorAgenteRetencionoPercepcion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorAgenteRetencionoPercepcionType IndicadorAgenteRetencionoPercepcionValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndicadorAgenteRetencionoPercepcionValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<IndicadorAgenteRetencionoPercepcionType> IndicadorAgenteRetencionoPercepcion
    {
        get
        {
            if (this.IndicadorAgenteRetencionoPercepcionValueSpecified)
            {
                return this.IndicadorAgenteRetencionoPercepcionValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.IndicadorAgenteRetencionoPercepcionValue = value.GetValueOrDefault();
            this.IndicadorAgenteRetencionoPercepcionValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoITBISRetenido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoITBISRetenidoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoITBISRetenidoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoITBISRetenido
    {
        get
        {
            if (this.MontoITBISRetenidoValueSpecified)
            {
                return this.MontoITBISRetenidoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoITBISRetenidoValue = value.GetValueOrDefault();
            this.MontoITBISRetenidoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoISRRetenido", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoISRRetenidoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoISRRetenidoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoISRRetenido
    {
        get
        {
            if (this.MontoISRRetenidoValueSpecified)
            {
                return this.MontoISRRetenidoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoISRRetenidoValue = value.GetValueOrDefault();
            this.MontoISRRetenidoValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubcantidad", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubcantidad
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem> _subcantidadItem;

    [System.Xml.Serialization.XmlElementAttribute("SubcantidadItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem> SubcantidadItem
    {
        get
        {
            return this._subcantidadItem;
        }
        private set
        {
            this._subcantidadItem = value;
        }
    }

    public ECFDetallesItemsItemTablaSubcantidad()
    {
        this._subcantidadItem = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubcantidadSubcantidadItem>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubcantidadSubcantidadItem", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubcantidadSubcantidadItem
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(.[0-9]{1,3})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Subcantidad", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubcantidadValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubcantidadValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> Subcantidad
    {
        get
        {
            if (this.SubcantidadValueSpecified)
            {
                return this.SubcantidadValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubcantidadValue = value.GetValueOrDefault();
            this.SubcantidadValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CodigoSubcantidad", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public UnidadMedidaType CodigoSubcantidadValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool CodigoSubcantidadValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<UnidadMedidaType> CodigoSubcantidad
    {
        get
        {
            if (this.CodigoSubcantidadValueSpecified)
            {
                return this.CodigoSubcantidadValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.CodigoSubcantidadValue = value.GetValueOrDefault();
            this.CodigoSubcantidadValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubDescuento", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubDescuento
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento> _subDescuento;

    [System.Xml.Serialization.XmlElementAttribute("SubDescuento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento> SubDescuento
    {
        get
        {
            return this._subDescuento;
        }
        private set
        {
            this._subDescuento = value;
        }
    }

    public ECFDetallesItemsItemTablaSubDescuento()
    {
        this._subDescuento = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubDescuentoSubDescuento>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubDescuentoSubDescuento", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubDescuentoSubDescuento
{

    [System.Xml.Serialization.XmlElementAttribute("TipoSubDescuento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoDescuentoRecargoType TipoSubDescuento { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubDescuentoPorcentaje", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubDescuentoPorcentajeValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubDescuentoPorcentajeValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubDescuentoPorcentaje
    {
        get
        {
            if (this.SubDescuentoPorcentajeValueSpecified)
            {
                return this.SubDescuentoPorcentajeValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubDescuentoPorcentajeValue = value.GetValueOrDefault();
            this.SubDescuentoPorcentajeValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoSubDescuento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoSubDescuentoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoSubDescuentoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoSubDescuento
    {
        get
        {
            if (this.MontoSubDescuentoValueSpecified)
            {
                return this.MontoSubDescuentoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoSubDescuentoValue = value.GetValueOrDefault();
            this.MontoSubDescuentoValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubRecargo", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubRecargo
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo> _subRecargo;

    [System.Xml.Serialization.XmlElementAttribute("SubRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo> SubRecargo
    {
        get
        {
            return this._subRecargo;
        }
        private set
        {
            this._subRecargo = value;
        }
    }

    public ECFDetallesItemsItemTablaSubRecargo()
    {
        this._subRecargo = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaSubRecargoSubRecargo>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaSubRecargoSubRecargo", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaSubRecargoSubRecargo
{

    [System.Xml.Serialization.XmlElementAttribute("TipoSubRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoDescuentoRecargoType TipoSubRecargo { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubRecargoPorcentaje", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubRecargoPorcentajeValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubRecargoPorcentajeValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubRecargoPorcentaje
    {
        get
        {
            if (this.SubRecargoPorcentajeValueSpecified)
            {
                return this.SubRecargoPorcentajeValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubRecargoPorcentajeValue = value.GetValueOrDefault();
            this.SubRecargoPorcentajeValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoSubRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoSubRecargoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoSubRecargoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoSubRecargo
    {
        get
        {
            if (this.MontoSubRecargoValueSpecified)
            {
                return this.MontoSubRecargoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoSubRecargoValue = value.GetValueOrDefault();
            this.MontoSubRecargoValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaImpuestoAdicional", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaImpuestoAdicional
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> _impuestoAdicional;

    [System.Xml.Serialization.XmlElementAttribute("ImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional> ImpuestoAdicional
    {
        get
        {
            return this._impuestoAdicional;
        }
        private set
        {
            this._impuestoAdicional = value;
        }
    }

    public ECFDetallesItemsItemTablaImpuestoAdicional()
    {
        this._impuestoAdicional = new System.Collections.ObjectModel.Collection<ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemTablaImpuestoAdicionalImpuestoAdicional
{

    [System.Xml.Serialization.XmlElementAttribute("TipoImpuesto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CodificacionTipoImpuestosType TipoImpuesto { get; set; }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDetallesItemsItemOtraMonedaDetalle", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDetallesItemsItemOtraMonedaDetalle
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(\\d{1,16})(\\.\\d{1,4})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrecioOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal PrecioOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool PrecioOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> PrecioOtraMoneda
    {
        get
        {
            if (this.PrecioOtraMonedaValueSpecified)
            {
                return this.PrecioOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.PrecioOtraMonedaValue = value.GetValueOrDefault();
            this.PrecioOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DescuentoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal DescuentoOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool DescuentoOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> DescuentoOtraMoneda
    {
        get
        {
            if (this.DescuentoOtraMonedaValueSpecified)
            {
                return this.DescuentoOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.DescuentoOtraMonedaValue = value.GetValueOrDefault();
            this.DescuentoOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RecargoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal RecargoOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool RecargoOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> RecargoOtraMoneda
    {
        get
        {
            if (this.RecargoOtraMonedaValueSpecified)
            {
                return this.RecargoOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.RecargoOtraMonedaValue = value.GetValueOrDefault();
            this.RecargoOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoItemOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoItemOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoItemOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoItemOtraMoneda
    {
        get
        {
            if (this.MontoItemOtraMonedaValueSpecified)
            {
                return this.MontoItemOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoItemOtraMonedaValue = value.GetValueOrDefault();
            this.MontoItemOtraMonedaValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFSubtotales", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFSubtotales
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal> _subtotal;

    [System.Xml.Serialization.XmlElementAttribute("Subtotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal> Subtotal
    {
        get
        {
            return this._subtotal;
        }
        private set
        {
            this._subtotal = value;
        }
    }

    public ECFSubtotales()
    {
        this._subtotal = new System.Collections.ObjectModel.Collection<ECFSubtotalesSubtotal>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFSubtotalesSubtotal", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFSubtotalesSubtotal
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NumeroSubTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte NumeroSubTotalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool NumeroSubTotalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> NumeroSubTotal
    {
        get
        {
            if (this.NumeroSubTotalValueSpecified)
            {
                return this.NumeroSubTotalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.NumeroSubTotalValue = value.GetValueOrDefault();
            this.NumeroSubTotalValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(40)]
    [System.Xml.Serialization.XmlElementAttribute("DescripcionSubtotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionSubtotal { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Orden", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte OrdenValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool OrdenValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> Orden
    {
        get
        {
            if (this.OrdenValueSpecified)
            {
                return this.OrdenValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.OrdenValue = value.GetValueOrDefault();
            this.OrdenValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalMontoGravadoTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoTotalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalMontoGravadoTotalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalMontoGravadoTotal
    {
        get
        {
            if (this.SubTotalMontoGravadoTotalValueSpecified)
            {
                return this.SubTotalMontoGravadoTotalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalMontoGravadoTotalValue = value.GetValueOrDefault();
            this.SubTotalMontoGravadoTotalValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalMontoGravadoI1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoI1Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalMontoGravadoI1ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalMontoGravadoI1
    {
        get
        {
            if (this.SubTotalMontoGravadoI1ValueSpecified)
            {
                return this.SubTotalMontoGravadoI1Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalMontoGravadoI1Value = value.GetValueOrDefault();
            this.SubTotalMontoGravadoI1ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalMontoGravadoI2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoI2Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalMontoGravadoI2ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalMontoGravadoI2
    {
        get
        {
            if (this.SubTotalMontoGravadoI2ValueSpecified)
            {
                return this.SubTotalMontoGravadoI2Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalMontoGravadoI2Value = value.GetValueOrDefault();
            this.SubTotalMontoGravadoI2ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalMontoGravadoI3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalMontoGravadoI3Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalMontoGravadoI3ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalMontoGravadoI3
    {
        get
        {
            if (this.SubTotalMontoGravadoI3ValueSpecified)
            {
                return this.SubTotalMontoGravadoI3Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalMontoGravadoI3Value = value.GetValueOrDefault();
            this.SubTotalMontoGravadoI3ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotaITBIS", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotaITBISValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotaITBISValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotaITBIS
    {
        get
        {
            if (this.SubTotaITBISValueSpecified)
            {
                return this.SubTotaITBISValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotaITBISValue = value.GetValueOrDefault();
            this.SubTotaITBISValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotaITBIS1", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotaITBIS1Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotaITBIS1ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotaITBIS1
    {
        get
        {
            if (this.SubTotaITBIS1ValueSpecified)
            {
                return this.SubTotaITBIS1Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotaITBIS1Value = value.GetValueOrDefault();
            this.SubTotaITBIS1ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotaITBIS2", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotaITBIS2Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotaITBIS2ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotaITBIS2
    {
        get
        {
            if (this.SubTotaITBIS2ValueSpecified)
            {
                return this.SubTotaITBIS2Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotaITBIS2Value = value.GetValueOrDefault();
            this.SubTotaITBIS2ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotaITBIS3", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotaITBIS3Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotaITBIS3ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotaITBIS3
    {
        get
        {
            if (this.SubTotaITBIS3ValueSpecified)
            {
                return this.SubTotaITBIS3Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotaITBIS3Value = value.GetValueOrDefault();
            this.SubTotaITBIS3ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalImpuestoAdicionalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalImpuestoAdicionalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalImpuestoAdicional
    {
        get
        {
            if (this.SubTotalImpuestoAdicionalValueSpecified)
            {
                return this.SubTotalImpuestoAdicionalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalImpuestoAdicionalValue = value.GetValueOrDefault();
            this.SubTotalImpuestoAdicionalValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTotalExento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubTotalExentoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubTotalExentoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubTotalExento
    {
        get
        {
            if (this.SubTotalExentoValueSpecified)
            {
                return this.SubTotalExentoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubTotalExentoValue = value.GetValueOrDefault();
            this.SubTotalExentoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoSubTotal", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoSubTotalValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoSubTotalValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoSubTotal
    {
        get
        {
            if (this.MontoSubTotalValueSpecified)
            {
                return this.MontoSubTotalValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoSubTotalValue = value.GetValueOrDefault();
            this.MontoSubTotalValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Lineas", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte LineasValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool LineasValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<sbyte> Lineas
    {
        get
        {
            if (this.LineasValueSpecified)
            {
                return this.LineasValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.LineasValue = value.GetValueOrDefault();
            this.LineasValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDescuentosORecargos", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDescuentosORecargos
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo> _descuentoORecargo;

    [System.Xml.Serialization.XmlElementAttribute("DescuentoORecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo> DescuentoORecargo
    {
        get
        {
            return this._descuentoORecargo;
        }
        private set
        {
            this._descuentoORecargo = value;
        }
    }

    public ECFDescuentosORecargos()
    {
        this._descuentoORecargo = new System.Collections.ObjectModel.Collection<ECFDescuentosORecargosDescuentoORecargo>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFDescuentosORecargosDescuentoORecargo", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFDescuentosORecargosDescuentoORecargo
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,2}")]
    [System.Xml.Serialization.XmlElementAttribute("NumeroLinea", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public sbyte NumeroLinea { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("TipoAjuste", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoAjusteType TipoAjuste { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicadorNorma1007", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorNorma1007Type IndicadorNorma1007Value { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndicadorNorma1007ValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<IndicadorNorma1007Type> IndicadorNorma1007
    {
        get
        {
            if (this.IndicadorNorma1007ValueSpecified)
            {
                return this.IndicadorNorma1007Value;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.IndicadorNorma1007Value = value.GetValueOrDefault();
            this.IndicadorNorma1007ValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(45)]
    [System.Xml.Serialization.XmlElementAttribute("DescripcionDescuentooRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionDescuentooRecargo { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TipoValor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TipoDescuentoRecargoType TipoValorValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool TipoValorValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<TipoDescuentoRecargoType> TipoValor
    {
        get
        {
            if (this.TipoValorValueSpecified)
            {
                return this.TipoValorValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.TipoValorValue = value.GetValueOrDefault();
            this.TipoValorValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}(.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValorDescuentooRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal ValorDescuentooRecargoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool ValorDescuentooRecargoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> ValorDescuentooRecargo
    {
        get
        {
            if (this.ValorDescuentooRecargoValueSpecified)
            {
                return this.ValorDescuentooRecargoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.ValorDescuentooRecargoValue = value.GetValueOrDefault();
            this.ValorDescuentooRecargoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoDescuentooRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoDescuentooRecargoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoDescuentooRecargoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoDescuentooRecargo
    {
        get
        {
            if (this.MontoDescuentooRecargoValueSpecified)
            {
                return this.MontoDescuentooRecargoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoDescuentooRecargoValue = value.GetValueOrDefault();
            this.MontoDescuentooRecargoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoDescuentooRecargoOtraMoneda", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoDescuentooRecargoOtraMonedaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoDescuentooRecargoOtraMonedaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoDescuentooRecargoOtraMoneda
    {
        get
        {
            if (this.MontoDescuentooRecargoOtraMonedaValueSpecified)
            {
                return this.MontoDescuentooRecargoOtraMonedaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoDescuentooRecargoOtraMonedaValue = value.GetValueOrDefault();
            this.MontoDescuentooRecargoOtraMonedaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicadorFacturacionDescuentooRecargo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public IndicadorFacturacionDRType IndicadorFacturacionDescuentooRecargoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool IndicadorFacturacionDescuentooRecargoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<IndicadorFacturacionDRType> IndicadorFacturacionDescuentooRecargo
    {
        get
        {
            if (this.IndicadorFacturacionDescuentooRecargoValueSpecified)
            {
                return this.IndicadorFacturacionDescuentooRecargoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.IndicadorFacturacionDescuentooRecargoValue = value.GetValueOrDefault();
            this.IndicadorFacturacionDescuentooRecargoValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFPaginacion", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFPaginacion
{

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    private System.Collections.ObjectModel.Collection<ECFPaginacionPagina> _pagina;

    [System.Xml.Serialization.XmlElementAttribute("Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public System.Collections.ObjectModel.Collection<ECFPaginacionPagina> Pagina
    {
        get
        {
            return this._pagina;
        }
        private set
        {
            this._pagina = value;
        }
    }

    public ECFPaginacion()
    {
        this._pagina = new System.Collections.ObjectModel.Collection<ECFPaginacionPagina>();
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFPaginacionPagina", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFPaginacionPagina
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}")]
    [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "1", "100")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaginaNo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public short PaginaNoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool PaginaNoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<short> PaginaNo
    {
        get
        {
            if (this.PaginaNoValueSpecified)
            {
                return this.PaginaNoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.PaginaNoValue = value.GetValueOrDefault();
            this.PaginaNoValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}")]
    [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "1", "100")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NoLineaDesde", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public short NoLineaDesdeValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool NoLineaDesdeValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<short> NoLineaDesde
    {
        get
        {
            if (this.NoLineaDesdeValueSpecified)
            {
                return this.NoLineaDesdeValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.NoLineaDesdeValue = value.GetValueOrDefault();
            this.NoLineaDesdeValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,3}")]
    [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "1", "100")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NoLineaHasta", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public short NoLineaHastaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool NoLineaHastaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<short> NoLineaHasta
    {
        get
        {
            if (this.NoLineaHastaValueSpecified)
            {
                return this.NoLineaHastaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.NoLineaHastaValue = value.GetValueOrDefault();
            this.NoLineaHastaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalMontoGravadoPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalMontoGravadoPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalMontoGravadoPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalMontoGravadoPagina
    {
        get
        {
            if (this.SubtotalMontoGravadoPaginaValueSpecified)
            {
                return this.SubtotalMontoGravadoPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalMontoGravadoPaginaValue = value.GetValueOrDefault();
            this.SubtotalMontoGravadoPaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalMontoGravado1Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalMontoGravado1PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalMontoGravado1PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalMontoGravado1Pagina
    {
        get
        {
            if (this.SubtotalMontoGravado1PaginaValueSpecified)
            {
                return this.SubtotalMontoGravado1PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalMontoGravado1PaginaValue = value.GetValueOrDefault();
            this.SubtotalMontoGravado1PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalMontoGravado2Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalMontoGravado2PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalMontoGravado2PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalMontoGravado2Pagina
    {
        get
        {
            if (this.SubtotalMontoGravado2PaginaValueSpecified)
            {
                return this.SubtotalMontoGravado2PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalMontoGravado2PaginaValue = value.GetValueOrDefault();
            this.SubtotalMontoGravado2PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalMontoGravado3Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalMontoGravado3PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalMontoGravado3PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalMontoGravado3Pagina
    {
        get
        {
            if (this.SubtotalMontoGravado3PaginaValueSpecified)
            {
                return this.SubtotalMontoGravado3PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalMontoGravado3PaginaValue = value.GetValueOrDefault();
            this.SubtotalMontoGravado3PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalExentoPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalExentoPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalExentoPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalExentoPagina
    {
        get
        {
            if (this.SubtotalExentoPaginaValueSpecified)
            {
                return this.SubtotalExentoPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalExentoPaginaValue = value.GetValueOrDefault();
            this.SubtotalExentoPaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalItbisPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalItbisPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalItbisPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalItbisPagina
    {
        get
        {
            if (this.SubtotalItbisPaginaValueSpecified)
            {
                return this.SubtotalItbisPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalItbisPaginaValue = value.GetValueOrDefault();
            this.SubtotalItbisPaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalItbis1Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalItbis1PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalItbis1PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalItbis1Pagina
    {
        get
        {
            if (this.SubtotalItbis1PaginaValueSpecified)
            {
                return this.SubtotalItbis1PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalItbis1PaginaValue = value.GetValueOrDefault();
            this.SubtotalItbis1PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalItbis2Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalItbis2PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalItbis2PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalItbis2Pagina
    {
        get
        {
            if (this.SubtotalItbis2PaginaValueSpecified)
            {
                return this.SubtotalItbis2PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalItbis2PaginaValue = value.GetValueOrDefault();
            this.SubtotalItbis2PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalItbis3Pagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalItbis3PaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalItbis3PaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalItbis3Pagina
    {
        get
        {
            if (this.SubtotalItbis3PaginaValueSpecified)
            {
                return this.SubtotalItbis3PaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalItbis3PaginaValue = value.GetValueOrDefault();
            this.SubtotalItbis3PaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalImpuestoAdicionalPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalImpuestoAdicionalPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalImpuestoAdicionalPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalImpuestoAdicionalPagina
    {
        get
        {
            if (this.SubtotalImpuestoAdicionalPaginaValueSpecified)
            {
                return this.SubtotalImpuestoAdicionalPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalImpuestoAdicionalPaginaValue = value.GetValueOrDefault();
            this.SubtotalImpuestoAdicionalPaginaValueSpecified = value.HasValue;
        }
    }

    [System.Xml.Serialization.XmlElementAttribute("SubtotalImpuestoAdicional", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ECFPaginacionPaginaSubtotalImpuestoAdicional SubtotalImpuestoAdicional { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MontoSubtotalPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal MontoSubtotalPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool MontoSubtotalPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> MontoSubtotalPagina
    {
        get
        {
            if (this.MontoSubtotalPaginaValueSpecified)
            {
                return this.MontoSubtotalPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.MontoSubtotalPaginaValue = value.GetValueOrDefault();
            this.MontoSubtotalPaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalMontoNoFacturablePagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalMontoNoFacturablePaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalMontoNoFacturablePaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalMontoNoFacturablePagina
    {
        get
        {
            if (this.SubtotalMontoNoFacturablePaginaValueSpecified)
            {
                return this.SubtotalMontoNoFacturablePaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalMontoNoFacturablePaginaValue = value.GetValueOrDefault();
            this.SubtotalMontoNoFacturablePaginaValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFPaginacionPaginaSubtotalImpuestoAdicional", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFPaginacionPaginaSubtotalImpuestoAdicional
{

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalImpuestoSelectivoConsumoEspecificoPagina", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalImpuestoSelectivoConsumoEspecificoPaginaValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalImpuestoSelectivoConsumoEspecificoPaginaValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalImpuestoSelectivoConsumoEspecificoPagina
    {
        get
        {
            if (this.SubtotalImpuestoSelectivoConsumoEspecificoPaginaValueSpecified)
            {
                return this.SubtotalImpuestoSelectivoConsumoEspecificoPaginaValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalImpuestoSelectivoConsumoEspecificoPaginaValue = value.GetValueOrDefault();
            this.SubtotalImpuestoSelectivoConsumoEspecificoPaginaValueSpecified = value.HasValue;
        }
    }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{1,16}(\\.[0-9]{1,2})?")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubtotalOtrosImpuesto", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal SubtotalOtrosImpuestoValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool SubtotalOtrosImpuestoValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<decimal> SubtotalOtrosImpuesto
    {
        get
        {
            if (this.SubtotalOtrosImpuestoValueSpecified)
            {
                return this.SubtotalOtrosImpuestoValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.SubtotalOtrosImpuestoValue = value.GetValueOrDefault();
            this.SubtotalOtrosImpuestoValueSpecified = value.HasValue;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.0.210.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ECFInformacionReferencia", Namespace = "", AnonymousType = true)]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class ECFInformacionReferencia
{

    [System.ComponentModel.DataAnnotations.MinLengthAttribute(11)]
    [System.ComponentModel.DataAnnotations.MaxLengthAttribute(19)]
    [System.Xml.Serialization.XmlElementAttribute("NCFModificado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string NCFModificado { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-9]{11}|[0-9]{9}")]
    [System.Xml.Serialization.XmlElementAttribute("RNCOtroContribuyente", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string RNCOtroContribuyente { get; set; }

    [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("(3[01]|[12][0-9]|0?[1-9])\\-(1[012]|0?[1-9])\\-((19|20)\\d{2})")]
    [System.Xml.Serialization.XmlElementAttribute("FechaNCFModificado", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string FechaNCFModificado { get; set; }

    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CodigoModificacion", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public CodigoModificacionType CodigoModificacionValue { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public bool CodigoModificacionValueSpecified { get; set; }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public System.Nullable<CodigoModificacionType> CodigoModificacion
    {
        get
        {
            if (this.CodigoModificacionValueSpecified)
            {
                return this.CodigoModificacionValue;
            }
            else
            {
                return null;
            }
        }
        set
        {
            this.CodigoModificacionValue = value.GetValueOrDefault();
            this.CodigoModificacionValueSpecified = value.HasValue;
        }
    }
}



