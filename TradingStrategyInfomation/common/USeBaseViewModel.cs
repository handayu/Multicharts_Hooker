using System;
using System.ComponentModel;
using System.Reflection;
using System.Linq.Expressions;

namespace TradingStrategyInfomation.common
{
    /// <summary>
    /// 属性改变监听类。
    /// </summary>
    public class USeBaseViewModel : INotifyPropertyChanged
    {
        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        virtual internal protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void SetProperty<T>(ref T propertyField, T value, Expression<Func<T>> expr)
        {
            var bodyExpr = expr.Body as System.Linq.Expressions.MemberExpression;
            if (bodyExpr == null)
            {
                throw new ArgumentException("Expression must be a MemberExpression!", "expr");
            }

            var propInfo = bodyExpr.Member as PropertyInfo;
            if (propInfo == null)
            {
                throw new ArgumentException("Expression must be a PropertyExpression!", "expr");
            }

            var propName = propInfo.Name;
            propertyField = value;
            this.OnPropertyChanged(propName);
        }

        protected void SetProperty<T>(Expression<Func<T>> expr)
        {
            var bodyExpr = expr.Body as System.Linq.Expressions.MemberExpression;
            if (bodyExpr == null)
            {
                throw new ArgumentException("Expression must be a MemberExpression!", "expr");
            }

            var propInfo = bodyExpr.Member as PropertyInfo;
            if (propInfo == null)
            {
                throw new ArgumentException("Expression must be a PropertyExpression!", "expr");
            }

            var propName = propInfo.Name;
            this.OnPropertyChanged(propName);
        }
        #endregion
    }
}
