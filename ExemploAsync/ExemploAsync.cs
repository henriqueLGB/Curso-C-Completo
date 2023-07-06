using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAsync
{
    public class ExemploAsync
    {
        //Método Task com retorno Task<TResult>
        async Task<bool> TaskTResultAsync()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        //Método com retorno void (Task)
        async Task TaskVoidAsync()
        {
            await Task.Delay(2000);
            Form1.lstRes.Items.Add("Tarefa longa executada");
        }

        public async Task TaskLongaDuracao()
        {
            bool isAnoBissexto = await TaskTResultAsync();

            Form1.lstRes.Items.Add($"{DateTime.Now.Year} {(isAnoBissexto ? " é " : " não é ")} um Ano Bissexto");
            await TaskVoidAsync();
        }

    }
}
