//Clase usuario

public class User {

    internal int iID; //ID
    private string sName; //Nombre
    private string sSurname; //Apellido
    private string sUser; //Usuario
    private string sPassword; //Contrasenia
    private string sEmail; //Mail

    private int iDNI; //DNI (Agregado)

    public User()
    {
    iID = 0;
    sName = string.Empty;
    sSurname = string.Empty;
    sUser = string.Empty;
    sPassword = string.Empty;
    sEmail = string.Empty;

    iDNI = 0;

    }

}

//Clase producto

public class Product
{

    internal int iID; //ID
    private string sDescription; //Descripcion
    internal float fPrice; //Precio
    internal int iStock; //Stock
    //Sacado de User
    internal int iUserID; //ID de Usuario

    private string sGuitarBrand; //Marca del producto (agregado)
    private string sGuitarModel; //Modelo del producto (Agregado)
    private bool bCombo; //Si el producto va con otros productos (Agregado)

    public Product()
    {
        iID = 0;
        sDescription = string.Empty;
        fPrice = 0;
        iStock = 0;
        iUserID = 0;


        sGuitarBrand = string.Empty;
        sGuitarModel = string.Empty;
        bCombo = false;

    }

}

//Clase Venta
public class Transaction
{

    internal int iID; //ID
    private string sComment; //Comentarios
    internal short shRank; //Calificacion de la compra (Agregado)
    internal bool bReservation; //Si es una reserva (Agregado)
    internal string sPayment; //Metodo de pago (Agregado)
    //Sacado de User
    internal int iUserID; //ID de Usuario
    //Sacado de producto
    internal float fPrice; //Precio


    public Transaction()
    {
        iID = 0;
        sComment = string.Empty;
        shRank = 0;
        bReservation = false;
        sPayment = string.Empty;
        iUserID = 0;
        fPrice = 0;

    }

}


//Clase producto vendido

public class SoldProduct
{

    private int iID; //ID del producto vendido
    
    //Sacado de la clase Producto
    internal int iProductID; //ID del producto
    internal int iStock;  //Stock del producto
    internal float fPrice; //Precio
    //Sacado de ventas
    internal bool bReservation; //Si es una reserva (Agregado)
    internal int iTransactionID;  //ID de venta
    internal string sPayment; //Metodo de pago (Agregado)

    public SoldProduct()
    {
        iID = 0;
        bReservation = false;
        sPayment = string.Empty;

        iProductID = 0;
        iStock = 0;
        iTransactionID = 0;
        fPrice = 0;

    }

}