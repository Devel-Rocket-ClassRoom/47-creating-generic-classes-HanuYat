using System;

class Converter<TInput, TOutput>
{
    private Func<TInput, TOutput> _convertFunc;

    public Converter(Func<TInput, TOutput> converter)
    {
        _convertFunc = converter;
    }

    public TOutput Convert(TInput input)
    {
        return _convertFunc(input);
    }

    public TOutput[] ConvertAll(TInput[] inputs)
    {
        TOutput[] outputs = new TOutput[inputs.Length];

        for (int i = 0; i < inputs.Length; i++)
        {
            outputs[i] = Convert(inputs[i]);
        }
        return outputs;
    }
}