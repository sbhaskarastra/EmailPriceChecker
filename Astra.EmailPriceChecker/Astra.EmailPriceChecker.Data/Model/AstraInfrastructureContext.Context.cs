﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Astra.EmailPriceChecker.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AstraInfrastructureContext : DbContext
    {
        public AstraInfrastructureContext()
            : base("name=AstraInfrastructureContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<AccrualDescription> AccrualDescription { get; set; }
        public virtual DbSet<AccrualGroup> AccrualGroup { get; set; }
        public virtual DbSet<AccrualPayment> AccrualPayment { get; set; }
        public virtual DbSet<AccrualPaymentType> AccrualPaymentType { get; set; }
        public virtual DbSet<AccrualType> AccrualType { get; set; }
        public virtual DbSet<ApplicationRule> ApplicationRule { get; set; }
        public virtual DbSet<BBGInterestRateDownloadSettings> BBGInterestRateDownloadSettings { get; set; }
        public virtual DbSet<BBGPriceDownloadSettings> BBGPriceDownloadSettings { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Counterparty> Counterparty { get; set; }
        public virtual DbSet<CounterpartyCurrencyProperty> CounterpartyCurrencyProperty { get; set; }
        public virtual DbSet<CounterpartyPropertyDescription> CounterpartyPropertyDescription { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryOfRisk> CountryOfRisk { get; set; }
        public virtual DbSet<CreditFundHolidays> CreditFundHolidays { get; set; }
        public virtual DbSet<CreditSpreadHistory> CreditSpreadHistory { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyExchangeRates> CurrencyExchangeRates { get; set; }
        public virtual DbSet<CurrencyExchangeRatesTickers> CurrencyExchangeRatesTickers { get; set; }
        public virtual DbSet<DataProvider> DataProvider { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EmailBwicFilter> EmailBwicFilter { get; set; }
        public virtual DbSet<EmailBwicMonitor> EmailBwicMonitor { get; set; }
        public virtual DbSet<EmailBwicSecurityLatestPrice> EmailBwicSecurityLatestPrice { get; set; }
        public virtual DbSet<EmailBwicSecurityPrice> EmailBwicSecurityPrice { get; set; }
        public virtual DbSet<EmailComponent> EmailComponent { get; set; }
        public virtual DbSet<EmailComponents> EmailComponents { get; set; }
        public virtual DbSet<EmailEventLog> EmailEventLog { get; set; }
        public virtual DbSet<EmailType> EmailType { get; set; }
        public virtual DbSet<EmailUser> EmailUser { get; set; }
        public virtual DbSet<EmergingMarkets> EmergingMarkets { get; set; }
        public virtual DbSet<EmergingMarketsGroup> EmergingMarketsGroup { get; set; }
        public virtual DbSet<EmergingMarketsType> EmergingMarketsType { get; set; }
        public virtual DbSet<EquityType> EquityType { get; set; }
        public virtual DbSet<ExchangeHoliday> ExchangeHoliday { get; set; }
        public virtual DbSet<ExchangeHolidayLocation> ExchangeHolidayLocation { get; set; }
        public virtual DbSet<FactorHistory> FactorHistory { get; set; }
        public virtual DbSet<FactorHistoryLog> FactorHistoryLog { get; set; }
        public virtual DbSet<FundAccount> FundAccount { get; set; }
        public virtual DbSet<FundApplicationRule> FundApplicationRule { get; set; }
        public virtual DbSet<FundCommitment> FundCommitment { get; set; }
        public virtual DbSet<FundCommitmentLevel> FundCommitmentLevel { get; set; }
        public virtual DbSet<FundCommitmentPayReceive> FundCommitmentPayReceive { get; set; }
        public virtual DbSet<FundContact> FundContact { get; set; }
        public virtual DbSet<FundCurrencyProperty> FundCurrencyProperty { get; set; }
        public virtual DbSet<FundGav> FundGav { get; set; }
        public virtual DbSet<FundInvestor> FundInvestor { get; set; }
        public virtual DbSet<FundLeverage> FundLeverage { get; set; }
        public virtual DbSet<FundNav> FundNav { get; set; }
        public virtual DbSet<FundPerformanceCalculationType> FundPerformanceCalculationType { get; set; }
        public virtual DbSet<FundPerformanceSummary> FundPerformanceSummary { get; set; }
        public virtual DbSet<FundPosition> FundPosition { get; set; }
        public virtual DbSet<FundProfitAndLoss> FundProfitAndLoss { get; set; }
        public virtual DbSet<FundProperty> FundProperty { get; set; }
        public virtual DbSet<FundPropertyDescription> FundPropertyDescription { get; set; }
        public virtual DbSet<FundRule> FundRule { get; set; }
        public virtual DbSet<FundRuleBreach> FundRuleBreach { get; set; }
        public virtual DbSet<FundRuleTotal> FundRuleTotal { get; set; }
        public virtual DbSet<Funds> Funds { get; set; }
        public virtual DbSet<FundSummary> FundSummary { get; set; }
        public virtual DbSet<FundTradeExtractionType> FundTradeExtractionType { get; set; }
        public virtual DbSet<FundTradeExtractionTypeContact> FundTradeExtractionTypeContact { get; set; }
        public virtual DbSet<FundType> FundType { get; set; }
        public virtual DbSet<FXForwardRate> FXForwardRate { get; set; }
        public virtual DbSet<FxForwardRateTickers> FxForwardRateTickers { get; set; }
        public virtual DbSet<FXMaster> FXMaster { get; set; }
        public virtual DbSet<HistoryAction> HistoryAction { get; set; }
        public virtual DbSet<HistoryStatus> HistoryStatus { get; set; }
        public virtual DbSet<IndustryType> IndustryType { get; set; }
        public virtual DbSet<InterestRateHistory> InterestRateHistory { get; set; }
        public virtual DbSet<Investor> Investor { get; set; }
        public virtual DbSet<Issuer> Issuer { get; set; }
        public virtual DbSet<OperationsTrades> OperationsTrades { get; set; }
        public virtual DbSet<PriceHistory> PriceHistory { get; set; }
        public virtual DbSet<PriceHistoryLog> PriceHistoryLog { get; set; }
        public virtual DbSet<PriceHistoryReturns> PriceHistoryReturns { get; set; }
        public virtual DbSet<RatingType> RatingType { get; set; }
        public virtual DbSet<Rights> Rights { get; set; }
        public virtual DbSet<RiskCashflowDefaultCashflow> RiskCashflowDefaultCashflow { get; set; }
        public virtual DbSet<RiskCashflowDefaultInputParameter> RiskCashflowDefaultInputParameter { get; set; }
        public virtual DbSet<RiskCashflowDefaultIsin> RiskCashflowDefaultIsin { get; set; }
        public virtual DbSet<RiskCashflowDetail> RiskCashflowDetail { get; set; }
        public virtual DbSet<RiskCashflowExecution> RiskCashflowExecution { get; set; }
        public virtual DbSet<RiskCashflowExecutionRun> RiskCashflowExecutionRun { get; set; }
        public virtual DbSet<RiskCashflowFieldDescription> RiskCashflowFieldDescription { get; set; }
        public virtual DbSet<RiskCashflowFieldProperty> RiskCashflowFieldProperty { get; set; }
        public virtual DbSet<RiskCashflowInputParameter> RiskCashflowInputParameter { get; set; }
        public virtual DbSet<RiskCashflowInputParameterDefaults> RiskCashflowInputParameterDefaults { get; set; }
        public virtual DbSet<RiskCashflowInputParameterNightly> RiskCashflowInputParameterNightly { get; set; }
        public virtual DbSet<RiskCashflowIsinProperty> RiskCashflowIsinProperty { get; set; }
        public virtual DbSet<RiskCashflowIsinPropertyDescription> RiskCashflowIsinPropertyDescription { get; set; }
        public virtual DbSet<RiskCashflowResult> RiskCashflowResult { get; set; }
        public virtual DbSet<RiskExecutionSimulationType> RiskExecutionSimulationType { get; set; }
        public virtual DbSet<RiskExecutionTask> RiskExecutionTask { get; set; }
        public virtual DbSet<RiskExecutionTaskCreditShiftRun> RiskExecutionTaskCreditShiftRun { get; set; }
        public virtual DbSet<RiskExecutionTaskExecutionType> RiskExecutionTaskExecutionType { get; set; }
        public virtual DbSet<RiskExecutionTaskInputParameter> RiskExecutionTaskInputParameter { get; set; }
        public virtual DbSet<RiskExecutionTaskInputParameterNightly> RiskExecutionTaskInputParameterNightly { get; set; }
        public virtual DbSet<RiskExecutionTaskInputParameterRun> RiskExecutionTaskInputParameterRun { get; set; }
        public virtual DbSet<RiskExecutionTaskPortfolioDetail> RiskExecutionTaskPortfolioDetail { get; set; }
        public virtual DbSet<RiskExecutionTaskResult> RiskExecutionTaskResult { get; set; }
        public virtual DbSet<RiskExecutionTaskRun> RiskExecutionTaskRun { get; set; }
        public virtual DbSet<RiskExecutionTaskRunResult> RiskExecutionTaskRunResult { get; set; }
        public virtual DbSet<RiskExecutionTaskValuationRunDetail> RiskExecutionTaskValuationRunDetail { get; set; }
        public virtual DbSet<RiskExecutionTaskValuationRunDetailCreditShift> RiskExecutionTaskValuationRunDetailCreditShift { get; set; }
        public virtual DbSet<RiskExecutionTaskValuationRunDetailResult> RiskExecutionTaskValuationRunDetailResult { get; set; }
        public virtual DbSet<RiskPool> RiskPool { get; set; }
        public virtual DbSet<RiskPoolDetail> RiskPoolDetail { get; set; }
        public virtual DbSet<RiskPoolDetailAmortisation> RiskPoolDetailAmortisation { get; set; }
        public virtual DbSet<RiskPoolResult> RiskPoolResult { get; set; }
        public virtual DbSet<Rules> Rules { get; set; }
        public virtual DbSet<RuleType> RuleType { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduledCashFlow> ScheduledCashFlow { get; set; }
        public virtual DbSet<ScheduledCashFlowHistory> ScheduledCashFlowHistory { get; set; }
        public virtual DbSet<ScheduleExecutionErrorLog> ScheduleExecutionErrorLog { get; set; }
        public virtual DbSet<ScheduleExecutionQueue> ScheduleExecutionQueue { get; set; }
        public virtual DbSet<SecurityMaster> SecurityMaster { get; set; }
        public virtual DbSet<SecurityMasterExchangeHolidayLocation> SecurityMasterExchangeHolidayLocation { get; set; }
        public virtual DbSet<SecurityMasterGlobalEthicalStandard> SecurityMasterGlobalEthicalStandard { get; set; }
        public virtual DbSet<SecurityMasterGlobalEthicalStandardFund> SecurityMasterGlobalEthicalStandardFund { get; set; }
        public virtual DbSet<SecurityMasterGroup> SecurityMasterGroup { get; set; }
        public virtual DbSet<SecurityMasterInstrument> SecurityMasterInstrument { get; set; }
        public virtual DbSet<SecurityMasterNotification> SecurityMasterNotification { get; set; }
        public virtual DbSet<SecurityMasterRegion> SecurityMasterRegion { get; set; }
        public virtual DbSet<SecurityMasterRestrictedList> SecurityMasterRestrictedList { get; set; }
        public virtual DbSet<SecurityMasterRiskPoolMapping> SecurityMasterRiskPoolMapping { get; set; }
        public virtual DbSet<SecurityMasterSensitivityReport> SecurityMasterSensitivityReport { get; set; }
        public virtual DbSet<SecurityMasterStrategy> SecurityMasterStrategy { get; set; }
        public virtual DbSet<SecurityMasterType> SecurityMasterType { get; set; }
        public virtual DbSet<ShareClass> ShareClass { get; set; }
        public virtual DbSet<ShareClassPerformanceSummary> ShareClassPerformanceSummary { get; set; }
        public virtual DbSet<ShareSeries> ShareSeries { get; set; }
        public virtual DbSet<ShareSeriesAmount> ShareSeriesAmount { get; set; }
        public virtual DbSet<ShareSeriesInvestor> ShareSeriesInvestor { get; set; }
        public virtual DbSet<ShareSeriesPerformanceSummary> ShareSeriesPerformanceSummary { get; set; }
        public virtual DbSet<ShareSeriesSummary> ShareSeriesSummary { get; set; }
        public virtual DbSet<SubscriptionRedemption> SubscriptionRedemption { get; set; }
        public virtual DbSet<SubscriptionRedemptionType> SubscriptionRedemptionType { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskExecutionErrorLog> TaskExecutionErrorLog { get; set; }
        public virtual DbSet<TaskExecutionQueue> TaskExecutionQueue { get; set; }
        public virtual DbSet<TaskExecutionStatus> TaskExecutionStatus { get; set; }
        public virtual DbSet<TaskGroup> TaskGroup { get; set; }
        public virtual DbSet<TickerMapping> TickerMapping { get; set; }
        public virtual DbSet<TradeBlueSky> TradeBlueSky { get; set; }
        public virtual DbSet<TradeExtractionContact> TradeExtractionContact { get; set; }
        public virtual DbSet<TradeExtractionLog> TradeExtractionLog { get; set; }
        public virtual DbSet<TradeExtractionStatus> TradeExtractionStatus { get; set; }
        public virtual DbSet<TradeExtractionType> TradeExtractionType { get; set; }
        public virtual DbSet<TradeHistory> TradeHistory { get; set; }
        public virtual DbSet<Trades> Trades { get; set; }
        public virtual DbSet<TradeType> TradeType { get; set; }
        public virtual DbSet<TradeTypeGroup> TradeTypeGroup { get; set; }
        public virtual DbSet<UserRights> UserRights { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
    }
}
