int estatusOperation = 5;
if (estatusOperation == (int)EstatusOperation.Exitoso)
{
    //..
}
else if (estatusOperation == (int)EstatusOperation.ClienteNoEncontrado)
{
    //*
}
else if (estatusOperation == (int)EstatusOperation.ErrorDeSistema)
{
    //++
}

public enum EstatusOperation
{
    Exitoso = 1,
    ClienteNoEncontrado = 2,
    ErrorDeSistema = 505
}