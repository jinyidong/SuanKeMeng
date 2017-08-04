using Core;
using Core.Events;
using SuanKeMeng.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuanKeMeng.Services
{
    public class ReplyHandler : ModelEventHandler
    {
        protected override void InitializeComponents()
        {
            AddEventListener<Create<Reply>>(OnCreate);
            AddEventListener<Update<Reply>>(OnUpdate);
            AddEventListener<Delete<Reply>>(OnDelete);
            AddEventListener<Select<Reply>>(OnSelect);
        }
        protected virtual async Task<Create<Reply>> OnCreate(Create<Reply> eventData,
            CallNext<Create<Reply>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.CreateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Update<Reply>> OnUpdate(Update<Reply> eventData,
           CallNext<Update<Reply>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.UpdateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Delete<Reply>> OnDelete(Delete<Reply> eventData,
            CallNext<Delete<Reply>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.DeleteAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Select<Reply>> OnSelect(Select<Reply> eventData,
            CallNext<Select<Reply>> callnext)
        {
            var query = eventData.Query;

            if (query == null)
                throw new ArgumentNullException("query");

            eventData.ReturnValue = await DataService.SelectAsync(query);

            return await callnext(eventData);
        }

    }

}
