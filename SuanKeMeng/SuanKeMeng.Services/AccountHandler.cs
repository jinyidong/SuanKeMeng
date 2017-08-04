using Core;
using Core.Events;
using SuanKeMeng.Models;
using System;
using System.Threading.Tasks;

namespace SuanKeMeng.Services
{
    public class AccountHandler : ModelEventHandler
    {
        protected override void InitializeComponents()
        {
            AddEventListener<Create<Account>>(OnCreate);
            AddEventListener<Update<Account>>(OnUpdate);
            AddEventListener<Delete<Account>>(OnDelete);
            AddEventListener<Select<Account>>(OnSelect);
        }
        protected virtual async Task<Create<Account>> OnCreate(Create<Account> eventData,
            CallNext<Create<Account>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.CreateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Update<Account>> OnUpdate(Update<Account> eventData,
           CallNext<Update<Account>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.UpdateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Delete<Account>> OnDelete(Delete<Account> eventData,
            CallNext<Delete<Account>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.DeleteAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Select<Account>> OnSelect(Select<Account> eventData,
            CallNext<Select<Account>> callnext)
        {
            var query = eventData.Query;

            if (query == null)
                throw new ArgumentNullException("query");

            eventData.ReturnValue = await DataService.SelectAsync(query);

            return await callnext(eventData);
        }

    }

}
